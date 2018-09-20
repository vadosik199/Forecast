using BasicForecaster.Interfaces;
using BasicForecaster.Models;
using BasicForecaster.Models.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForecaster
{
    public partial class ModelSelectionCard : Form
    {
        private dbContext dataContext = null;
        private Model_Selection dataModelSelection = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public ModelSelectionCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public ModelSelectionCard(string code, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.Model_Selections.Load();
            dataModelSelection = dataContext.Model_Selections.Where(u => u.Code.Equals(code)).FirstOrDefault();
            codeField.Text = dataModelSelection.Code;
            descriptionField.Text = dataModelSelection.Description;
            exTrendCheckBox.Checked = dataModelSelection.Ex_Trend == null ? false : (bool)dataModelSelection.Ex_Trend;
            exSeasonalCheckBox.Checked = dataModelSelection.Ex_Seasonal == null ? false : (bool)dataModelSelection.Ex_Seasonal;
            exTrendAndSeasonalCheckBox.Checked = dataModelSelection.Ex_Trend_And_Seasonal == null ? false : (bool)dataModelSelection.Ex_Trend_And_Seasonal;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.Model_Selections.Remove(dataModelSelection);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codeField_TextChanged(object sender, EventArgs e)
        {
            dataModelSelection.Code = codeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataModelSelection.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void exTrendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataModelSelection.Ex_Trend = exTrendCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void exSeasonalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataModelSelection.Ex_Seasonal = exSeasonalCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void exTrendAndSeasonalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataModelSelection.Ex_Trend_And_Seasonal = exTrendAndSeasonalCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void ModelSelectionCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
