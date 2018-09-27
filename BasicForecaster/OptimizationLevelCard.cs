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
        public bool IsNew { get; private set; }

        public OptimizationLevelCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.Optimization_Levels.Load();
            dataOptimizationLevel = new Optimization_Level();
            IsNew = isNew;

            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public OptimizationLevelCard(string code, Form parentForm)
            :this(parentForm)
        {           
            dataOptimizationLevel = dataContext.Optimization_Levels.Where(u => u.Code.Equals(code)).FirstOrDefault();
            codeField.Text = dataOptimizationLevel.Code;
            descriptionField.Text = dataOptimizationLevel.Description;
            fromMADField.Text = dataOptimizationLevel.From_MAD == null ? "" : dataOptimizationLevel.From_MAD.ToString();
            toMADField.Text = dataOptimizationLevel.To_MAD == null ? "" : dataOptimizationLevel.To_MAD.ToString();

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

        private void NewButton_Click(object sender, EventArgs e)
        {
            OptimizationLevelCard optimizationLevel = new OptimizationLevelCard(parentForm, true);
            optimizationLevel.Show();
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
                    if (context.Optimization_Levels.Where(vs => vs.Code.Equals(codeField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Code' = {codeField.Text} already exist!");
                    }
                    dataOptimizationLevel.Code = codeField.Text;
                    dataOptimizationLevel.Description = descriptionField.Text;
                    int val;
                    if (int.TryParse(fromMADField.Text, out val))
                    {
                        dataOptimizationLevel.From_MAD = val;
                    }
                    if (int.TryParse(toMADField.Text, out val))
                    {
                        dataOptimizationLevel.To_MAD = val;
                    }
                    context.Optimization_Levels.Add(dataOptimizationLevel);
                    context.SaveData(errorHandler);
                    OptimizationLevelCard card = new OptimizationLevelCard(dataOptimizationLevel.Code, parentForm);
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
