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

        public GeneralSetupCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public GeneralSetupCard(int companyNo, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.GeneralSetup.Load();
            dataGeneralSetup = dataContext.GeneralSetup.Where(u => u.CompanyNo == companyNo).FirstOrDefault();
            companyNoField.Text = dataGeneralSetup.CompanyNo.ToString();
            companyNameField.Text = dataGeneralSetup.CompanyName;
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
            int companyNo;
            if (int.TryParse(companyNoField.Text, out companyNo))
            {
                dataGeneralSetup.CompanyNo = companyNo;
            }
            dataContext.SaveData(errorHandler);
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
    }
}
