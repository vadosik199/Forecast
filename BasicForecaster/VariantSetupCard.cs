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

        public VariantSetupCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public VariantSetupCard(string itemCode, string variantCode, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.VariantSetup.Load();
            dataVariantSetup = dataContext.VariantSetup.Where(u => u.ItemCode.Equals(itemCode) && u.VariantCode.Equals(variantCode)).FirstOrDefault();
            itemCodeField.Text = dataVariantSetup.ItemCode;
            variantCodeField.Text = dataVariantSetup.VariantCode;
            descriptionField.Text = dataVariantSetup.Description;
            itemDescriptionField.Text = dataVariantSetup.ItemDescription;
            unitOfMeasureField.Text = dataVariantSetup.UnitOfMeasure;
            locationCodeField.Text = dataVariantSetup.LocationCode;
            customerVariantCode.Text = dataVariantSetup.CustomerVariantCode;
            vendorVariantCodeField.Text = dataVariantSetup.VendorVariantCode;
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
    }
}
