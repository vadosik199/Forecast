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

        public CustomerLocationCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public CustomerLocationCard(string customerLocationCode)
            :this()
        {
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
            dataCustomerLocation.Description = descriptionField.Text;
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
            dataCustomerLocation.Blocked = blockedCheckBox.Checked;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void storeNoField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerLocation.StoreNo = storeNoField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void posDataExistField_TextChanged(object sender, EventArgs e)
        {
            double posExist;
            if (double.TryParse(posDataExistField.Text, out posExist))
            {
                dataCustomerLocation.POSDataExist = posExist;
            }
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
