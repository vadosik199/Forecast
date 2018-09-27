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
    public partial class VariantSetupCard : Form
    {
        private dbContext dataContext = null;
        private VariantSetup dataVariantSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public VariantSetupCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
            dataVariantSetup = new VariantSetup();
            dataContext.VariantSetup.Load();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public VariantSetupCard(string itemCode, string variantCode, Form parentForm)
            :this(parentForm)
        {
            dataVariantSetup = dataContext.VariantSetup.Where(u => u.ItemCode.Equals(itemCode) && u.VariantCode.Equals(variantCode)).FirstOrDefault();
            itemCodeField.Text = dataVariantSetup.ItemCode;
            variantCodeField.Text = dataVariantSetup.VariantCode;
            descriptionField.Text = dataVariantSetup.Description;
            itemDescriptionField.Text = dataVariantSetup.ItemDescription;
            unitOfMeasureField.Text = dataVariantSetup.UnitOfMeasure;
            locationCodeField.Text = dataVariantSetup.LocationCode;
            customerVariantCode.Text = dataVariantSetup.CustomerVariantCode;
            vendorVariantCodeField.Text = dataVariantSetup.VendorVariantCode;

            if (!IsNew)
            {
                itemCodeField.Enabled = false;
                variantCodeField.Enabled = false;
                SaveButton.Visible = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.VariantSetup.Remove(dataVariantSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.ItemDescription = itemDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void locationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.LocationCode = locationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerVariantCode_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.CustomerVariantCode = customerVariantCode.Text;
            dataContext.SaveData(errorHandler);
        }

        private void vendorVariantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.VendorVariantCode = vendorVariantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void VariantSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            VariantSetupCard variantSetupCard = new VariantSetupCard(parentForm, true);
            variantSetupCard.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(itemCodeField.Text))
                    {
                        throw new Exception("Field 'Item Code' can`t be empty!");
                    }
                    if (string.IsNullOrEmpty(variantCodeField.Text))
                    {
                        throw new Exception("Field 'Variant Code' can`t be empty!");
                    }
                    if (context.VariantSetup.Where(vs => vs.ItemCode.Equals(itemCodeField.Text) && vs.VariantCode.Equals(variantCodeField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Item Code' = {itemCodeField.Text} and 'Variant Code' = {variantCodeField.Text} already exist!");
                    }
                    dataVariantSetup.ItemCode = itemCodeField.Text;
                    dataVariantSetup.VariantCode = variantCodeField.Text;
                    dataVariantSetup.Description = descriptionField.Text;
                    dataVariantSetup.ItemDescription = itemDescriptionField.Text;
                    dataVariantSetup.UnitOfMeasure = unitOfMeasureField.Text;
                    dataVariantSetup.LocationCode = locationCodeField.Text;
                    dataVariantSetup.CustomerVariantCode = customerVariantCode.Text;
                    dataVariantSetup.VendorVariantCode = vendorVariantCodeField.Text;
                    context.VariantSetup.Add(dataVariantSetup);
                    context.SaveData(errorHandler);
                    VariantSetupCard newVariantSetupCard = new VariantSetupCard(dataVariantSetup.ItemCode, dataVariantSetup.VariantCode, this.parentForm);
                    newVariantSetupCard.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
