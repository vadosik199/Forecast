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
        public bool IsNew { get; private set; }

        public VendorLocationSetupCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataContext = new dbContext();
            dataVendorLocation = new VendorLocation();
            dataContext.VendorLocation.Load();
            errorHandler = new WinFormErrorHandler();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public VendorLocationSetupCard(string locationCode, Form parentForm)
            :this(parentForm)
        {
            dataVendorLocation = dataContext.VendorLocation.Where(u => u.VendorLocationCode.Equals(locationCode)).FirstOrDefault();
            locationCodeField.Text = dataVendorLocation.VendorLocationCode;
            descriptionField.Text = dataVendorLocation.Description;
            blockedCheckBox.Checked = dataVendorLocation.Blocked == null ? false : (bool)dataVendorLocation.Blocked;

            if (!IsNew)
            {
                locationCodeField.Enabled = false;
                SaveButton.Visible = false;
            }
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

        private void NewButton_Click(object sender, EventArgs e)
        {
            VendorLocationSetupCard vendorLocationSetupCard = new VendorLocationSetupCard(this.parentForm, true);
            vendorLocationSetupCard.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(locationCodeField.Text))
                    {
                        throw new Exception("Field 'Vendor Location Code' can`t be empty!");
                    }
                    if (context.VendorLocation.Where(vs => vs.VendorLocationCode.Equals(locationCodeField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Vendor Location Code' = {locationCodeField.Text} already exist!");
                    }
                    dataVendorLocation.VendorLocationCode = locationCodeField.Text;
                    dataVendorLocation.Description = descriptionField.Text;
                    dataVendorLocation.Blocked = blockedCheckBox.Checked;
                    context.VendorLocation.Add(dataVendorLocation);
                    context.SaveData(errorHandler);
                    VendorLocationSetupCard newVendorLocationSetupCard = new VendorLocationSetupCard(dataVendorLocation.VendorLocationCode, this.parentForm);
                    newVendorLocationSetupCard.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
