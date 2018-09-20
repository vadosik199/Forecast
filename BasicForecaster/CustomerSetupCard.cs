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
    public partial class CustomerSetupCard : Form
    {
        private dbContext dataContext = null;
        private CustomerSetup dataCustomerSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public CustomerSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public CustomerSetupCard(string customerNo, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.CustomerSetup.Load();
            dataCustomerSetup = dataContext.CustomerSetup.Where(u => u.CustomerNo.Equals(customerNo)).FirstOrDefault();
            customerNoField.Text = dataCustomerSetup.CustomerNo;
            descriptionField.Text = dataCustomerSetup.Description;
            blockedCheckBox.Checked = dataCustomerSetup.Blocked == null ? false : (bool)dataCustomerSetup.Blocked;
            posDataExistCheckBox.Checked = dataCustomerSetup.POSDataExist == null ? false : (bool)dataCustomerSetup.POSDataExist;
            customerLocationCodeField.Text = dataCustomerSetup.CustomerLocationCode;
            customerBuyingCalendarField.Text = dataCustomerSetup.CustomerBuyingCalendar;
            retailerCodeField.Text = dataCustomerSetup.RetailerCode;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.CustomerSetup.Remove(dataCustomerSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerNoField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.CustomerNo = customerNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.Blocked = blockedCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void posDataExistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.POSDataExist = posDataExistCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void customerLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.CustomerLocationCode = customerNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerBuyingCalendarField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.CustomerBuyingCalendar = customerBuyingCalendarField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void retailerCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.RetailerCode = retailerCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void CustomerSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
