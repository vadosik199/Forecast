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

        public VariantSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public VariantSetupCard(string itemCode, string variantCode)
            :this()
        {
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
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.VariantCode = variantCodeField.Text;
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
            dataVariantSetup.Description = descriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.ItemDescription = itemDescriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.UnitOfMeasure = unitOfMeasureField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void locationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.LocationCode = locationCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerVariantCode_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.CustomerVariantCode = customerVariantCode.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vendorVariantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVariantSetup.VendorVariantCode = vendorVariantCodeField.Text;
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
