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
    public partial class GeneralSetupCard : Form
    {
        private dbContext dataContext = null;
        private GeneralSetup dataGeneralSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public GeneralSetupCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.GeneralSetup.Load();
            dataGeneralSetup = new GeneralSetup();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public GeneralSetupCard(int companyNo, Form parentForm)
            :this(parentForm)
        {          
            dataGeneralSetup = dataContext.GeneralSetup.Where(u => u.CompanyNo == companyNo).FirstOrDefault();
            companyNoField.Text = dataGeneralSetup.CompanyNo.ToString();
            companyNameField.Text = dataGeneralSetup.CompanyName;

            if (!IsNew)
            {
                companyNoField.Enabled = false;
                SaveButton.Visible = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.GeneralSetup.Remove(dataGeneralSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void companyNoField_TextChanged(object sender, EventArgs e)
        {
            /*int companyNo;
            if (int.TryParse(companyNoField.Text, out companyNo))
            {
                //dataContext.Entry(dataGeneralSetup).State = EntityState.Detached;
                dataGeneralSetup.CompanyNo = companyNo;
                //dataContext.Entry(dataGeneralSetup).State = EntityState.Modified;
            }
            dataContext.SaveData(errorHandler);*/
        }

        private void companyNameField_TextChanged(object sender, EventArgs e)
        {
            dataGeneralSetup.CompanyName = companyNameField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void GeneralSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void companyNoField_Leave(object sender, EventArgs e)
        {
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            GeneralSetupCard card = new GeneralSetupCard(parentForm, true);
            card.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(companyNoField.Text))
                    {
                        throw new Exception("Field 'Company No' can`t be empty!");
                    }
                    int no = int.Parse(companyNoField.Text);
                    if (context.GeneralSetup.Where(vs => vs.CompanyNo == no).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Company No' = {companyNoField.Text} already exist!");
                    }
                    int companyNo;
                    if (int.TryParse(companyNoField.Text, out companyNo))
                    {
                        dataGeneralSetup.CompanyNo = companyNo;
                    }
                    dataGeneralSetup.CompanyName = companyNameField.Text;
                    context.GeneralSetup.Add(dataGeneralSetup);
                    context.SaveData(errorHandler);
                    GeneralSetupCard card = new GeneralSetupCard(dataGeneralSetup.CompanyNo, parentForm);
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
