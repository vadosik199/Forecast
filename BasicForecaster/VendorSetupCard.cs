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
    public partial class VendorSetupCard : Form
    {
        private dbContext dataContext = null;
        private VendorSetup dataVendorSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public VendorSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public VendorSetupCard(string vendorNo, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.VendorSetup.Load();
            dataVendorSetup = dataContext.VendorSetup.Where(u => u.VendorNo.Equals(vendorNo)).FirstOrDefault();
            vendorNoField.Text = dataVendorSetup.VendorNo;
            descriptionField.Text = dataVendorSetup.Description;
            blockedCheckBox.Checked = dataVendorSetup.Blocked == null ? false : true;
            itemCodeField.Text = dataVendorSetup.ItemCode;
            itemDescriptionField.Text = dataVendorSetup.ItemDescription;
            foreach (var item in Enum.GetValues(typeof(DateOption)))
            {
                leadTimeUOMComboBox.Items.Add(item);
            }
            leadTimeUOMComboBox.SelectedIndex = dataVendorSetup.LeadTimeUOM == null ? -1 : (int)dataVendorSetup.LeadTimeUOM;
            leadTimeField.Text = dataVendorSetup.LeadTime.ToString();
            vendorLocationCodeField.Text = dataVendorSetup.VendorLocationCode;
            variantCodeField.Text = dataVendorSetup.VariantCode;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.VendorSetup.Remove(dataVendorSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vendorNoField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.VendorNo = vendorNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataVendorSetup.Blocked = blockedCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.ItemDescription = itemDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void leadTimeUOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataVendorSetup.LeadTimeUOM = (DateOption)leadTimeUOMComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void leadTimeField_TextChanged(object sender, EventArgs e)
        {
            decimal leadTime;
            if (decimal.TryParse(leadTimeField.Text, out leadTime))
            {
                dataVendorSetup.LeadTime = leadTime;
            }
            dataContext.SaveData(errorHandler);
        }

        private void vendorLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.VendorLocationCode = vendorLocationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void VendorSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
