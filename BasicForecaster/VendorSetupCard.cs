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
        public bool IsNew { get; private set; }

        public VendorSetupCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataContext = new dbContext();
            dataVendorSetup = new VendorSetup();
            dataContext.VendorSetup.Load();
            errorHandler = new WinFormErrorHandler();
            IsNew = isNew;
            foreach (var item in Enum.GetValues(typeof(DateOption)))
            {
                leadTimeUOMComboBox.Items.Add(item);
            }
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public VendorSetupCard(string vendorNo, Form parentForm)
            :this(parentForm)
        {
            dataVendorSetup = dataContext.VendorSetup.Where(u => u.VendorNo.Equals(vendorNo)).FirstOrDefault();
            vendorNoField.Text = dataVendorSetup.VendorNo;
            descriptionField.Text = dataVendorSetup.Description;
            blockedCheckBox.Checked = dataVendorSetup.Blocked == null ? false : true;
            itemCodeField.Text = dataVendorSetup.ItemCode;
            itemDescriptionField.Text = dataVendorSetup.ItemDescription;
            leadTimeUOMComboBox.SelectedIndex = dataVendorSetup.LeadTimeUOM == null ? -1 : (int)dataVendorSetup.LeadTimeUOM;
            leadTimeField.Text = dataVendorSetup.LeadTime.ToString();
            vendorLocationCodeField.Text = dataVendorSetup.VendorLocationCode;
            variantCodeField.Text = dataVendorSetup.VariantCode;
            
            if (!IsNew)
            {
                vendorNoField.Enabled = false;
                SaveButton.Visible = false;
            }

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
            //dataVendorSetup.VendorNo = vendorNoField.Text;
            //dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                dataVendorSetup.Description = descriptionField.Text;
                dataContext.SaveData(errorHandler);
            }
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                dataVendorSetup.Blocked = blockedCheckBox.Checked;
                dataContext.SaveData(errorHandler);
            }
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                dataVendorSetup.ItemDescription = itemDescriptionField.Text;
                dataContext.SaveData(errorHandler);
            }
        }

        private void leadTimeUOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                dataVendorSetup.LeadTimeUOM = (DateOption)leadTimeUOMComboBox.SelectedIndex;
                dataContext.SaveData(errorHandler);
            }
        }

        private void leadTimeField_TextChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                decimal leadTime;
                if (decimal.TryParse(leadTimeField.Text, out leadTime))
                {
                    dataVendorSetup.LeadTime = leadTime;
                }
                dataContext.SaveData(errorHandler);
            }
        }

        private void vendorLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                dataVendorSetup.VendorLocationCode = vendorLocationCodeField.Text;
                dataContext.SaveData(errorHandler);
            }
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                dataVendorSetup.VariantCode = variantCodeField.Text;
                dataContext.SaveData(errorHandler);
            }
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

        private void vendorNoField_Leave(object sender, EventArgs e)
        {
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            VendorSetupCard vendorSetupCard = new VendorSetupCard(this.parentForm, true);
            vendorSetupCard.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(vendorNoField.Text))
                    {
                        throw new Exception("Field 'Vendor No' can`t be empty!");
                    }
                    if (context.VendorSetup.Where(vs => vs.VendorNo.Equals(vendorNoField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Vendor No' = {vendorNoField.Text} already exist!");
                    }
                    dataVendorSetup.VendorNo = vendorNoField.Text;
                    dataVendorSetup.Description = descriptionField.Text;
                    dataVendorSetup.Blocked = blockedCheckBox.Checked;
                    dataVendorSetup.ItemCode = itemCodeField.Text;
                    dataVendorSetup.ItemDescription = itemDescriptionField.Text;
                    if (leadTimeUOMComboBox.SelectedIndex == -1)
                    {
                        dataVendorSetup.LeadTimeUOM = null;
                    }
                    else
                    {
                        dataVendorSetup.LeadTimeUOM = (DateOption)leadTimeUOMComboBox.SelectedIndex;
                    }
                    decimal leadTime;
                    if (decimal.TryParse(leadTimeField.Text, out leadTime))
                    {
                        dataVendorSetup.LeadTime = leadTime;
                    }
                    else
                    {
                        dataVendorSetup.LeadTime = null;
                    }
                    dataVendorSetup.VendorLocationCode = vendorLocationCodeField.Text;
                    dataVendorSetup.VariantCode = variantCodeField.Text;
                    context.VendorSetup.Add(dataVendorSetup);
                    context.SaveData(errorHandler);
                    VendorSetupCard newVendorSetupCard = new VendorSetupCard(dataVendorSetup.VendorNo, this.parentForm);
                    newVendorSetupCard.Show();
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
