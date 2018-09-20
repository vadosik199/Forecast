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
    public partial class OptimizationLevelCard : Form
    {
        private dbContext dataContext = null;
        private Optimization_Level dataOptimizationLevel = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public OptimizationLevelCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public OptimizationLevelCard(string code, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.Optimization_Levels.Load();
            dataOptimizationLevel = dataContext.Optimization_Levels.Where(u => u.Code.Equals(code)).FirstOrDefault();
            codeField.Text = dataOptimizationLevel.Code;
            descriptionField.Text = dataOptimizationLevel.Description;
            fromMADField.Text = dataOptimizationLevel.From_MAD == null ? "" : dataOptimizationLevel.From_MAD.ToString();
            toMADField.Text = dataOptimizationLevel.To_MAD == null ? "" : dataOptimizationLevel.To_MAD.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.Optimization_Levels.Remove(dataOptimizationLevel);
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
            dataOptimizationLevel.Code = codeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataOptimizationLevel.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void fromMADField_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(fromMADField.Text, out val))
            {
                dataOptimizationLevel.From_MAD = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void toMADField_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(toMADField.Text, out val))
            {
                dataOptimizationLevel.To_MAD = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void OptimizationLevelCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
