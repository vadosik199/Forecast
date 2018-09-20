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
    public partial class CustomerLocationCard : Form
    {
        private dbContext dataContext = null;
        private CustomerLocation dataCustomerLocation = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public CustomerLocationCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public CustomerLocationCard(string customerLocationCode, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.CustomerLocation.Load();
            dataCustomerLocation = dataContext.CustomerLocation.Where(u => u.CustomerLocationCode.Equals(customerLocationCode)).FirstOrDefault();
            customerLocationNoField.Text = dataCustomerLocation.CustomerLocationCode;
            descriptionField.Text = dataCustomerLocation.Description;
            blockedCheckBox.Checked = dataCustomerLocation.Blocked == null ? false : (bool)dataCustomerLocation.Blocked;
            posDataExistField.Text = dataCustomerLocation.POSDataExist == null ? "" : dataCustomerLocation.POSDataExist.ToString();
            storeNoField.Text = dataCustomerLocation.StoreNo;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.CustomerLocation.Remove(dataCustomerLocation);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerLocationNoField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerLocation.CustomerLocationCode = customerLocationNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerLocation.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataCustomerLocation.Blocked = blockedCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void storeNoField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerLocation.StoreNo = storeNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void posDataExistField_TextChanged(object sender, EventArgs e)
        {
            double posExist;
            if (double.TryParse(posDataExistField.Text, out posExist))
            {
                dataCustomerLocation.POSDataExist = posExist;
            }
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void CustomerLocationCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
