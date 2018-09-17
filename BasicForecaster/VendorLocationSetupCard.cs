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
    public partial class VendorLocationSetupCard : Form
    {
        private dbContext dataContext = null;
        private VendorLocation dataVendorLocation = null;

        public VendorLocationSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public VendorLocationSetupCard(string locationCode)
            :this()
        {
            dataContext.VendorLocation.Load();
            dataVendorLocation = dataContext.VendorLocation.Where(u => u.VendorLocationCode.Equals(locationCode)).FirstOrDefault();
            locationCodeField.Text = dataVendorLocation.VendorLocationCode;
            descriptionField.Text = dataVendorLocation.Description;
            blockedCheckBox.Checked = dataVendorLocation.Blocked == null ? false : true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.VendorLocation.Remove(dataVendorLocation);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void locationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorLocation.VendorLocationCode = locationCodeField.Text;
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
            dataVendorLocation.Description = descriptionField.Text;
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
            dataVendorLocation.Blocked = blockedCheckBox.Checked;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VendorLocationSetupCard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
