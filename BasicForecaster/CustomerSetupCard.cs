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

        public CustomerSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public CustomerSetupCard(string customerNo)
            :this()
        {
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
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.Description = descriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.Blocked = blockedCheckBox.Checked;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void posDataExistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.POSDataExist = posDataExistCheckBox.Checked;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.CustomerLocationCode = customerNoField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerBuyingCalendarField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.CustomerBuyingCalendar = customerBuyingCalendarField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retailerCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerSetup.RetailerCode = retailerCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
