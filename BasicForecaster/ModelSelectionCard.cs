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
        public bool IsNew { get; private set; }

        public ModelSelectionCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.Model_Selections.Load();
            dataModelSelection = new Model_Selection();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public ModelSelectionCard(string code, Form parentForm)
            :this(parentForm)
        {           
            dataModelSelection = dataContext.Model_Selections.Where(u => u.Code.Equals(code)).FirstOrDefault();
            codeField.Text = dataModelSelection.Code;
            descriptionField.Text = dataModelSelection.Description;
            exTrendCheckBox.Checked = dataModelSelection.Ex_Trend == null ? false : (bool)dataModelSelection.Ex_Trend;
            exSeasonalCheckBox.Checked = dataModelSelection.Ex_Seasonal == null ? false : (bool)dataModelSelection.Ex_Seasonal;
            exTrendAndSeasonalCheckBox.Checked = dataModelSelection.Ex_Trend_And_Seasonal == null ? false : (bool)dataModelSelection.Ex_Trend_And_Seasonal;

            if (!IsNew)
            {
                codeField.Enabled = false;
                SaveButton.Visible = false;
            }
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

        private void NewButton_Click(object sender, EventArgs e)
        {
            ModelSelectionCard card = new ModelSelectionCard(parentForm, true);
            card.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(codeField.Text))
                    {
                        throw new Exception("Field 'Code' can`t be empty!");
                    }
                    if (context.Model_Selections.Where(vs => vs.Code.Equals(codeField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Code' = {codeField.Text} already exist!");
                    }
                    dataModelSelection.Code = codeField.Text;
                    dataModelSelection.Description = descriptionField.Text;
                    dataModelSelection.Ex_Trend = exTrendCheckBox.Checked;
                    dataModelSelection.Ex_Seasonal = exSeasonalCheckBox.Checked;
                    dataModelSelection.Ex_Trend_And_Seasonal = exTrendAndSeasonalCheckBox.Checked;
                    context.Model_Selections.Add(dataModelSelection);
                    context.SaveData(errorHandler);
                    ModelSelectionCard card = new ModelSelectionCard(dataModelSelection.Code, parentForm);
                    card.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
