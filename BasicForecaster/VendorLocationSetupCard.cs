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
    public partial class VendorLocationSetupCard : Form
    {
        private dbContext dataContext = null;
        private VendorLocation dataVendorLocation = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public VendorLocationSetupCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public VendorLocationSetupCard(string locationCode, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
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
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataVendorLocation.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataVendorLocation.Blocked = blockedCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void VendorLocationSetupCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
