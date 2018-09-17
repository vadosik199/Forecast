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

        public VendorSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public VendorSetupCard(string vendorNo)
            :this()
        {
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
            dataVendorSetup.Description = descriptionField.Text;
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
            dataVendorSetup.Blocked = blockedCheckBox.Checked;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.ItemCode = itemCodeField.Text;
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
            dataVendorSetup.ItemDescription = itemDescriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void leadTimeUOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataVendorSetup.LeadTimeUOM = (DateOption)leadTimeUOMComboBox.SelectedIndex;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void leadTimeField_TextChanged(object sender, EventArgs e)
        {
            decimal leadTime;
            if (decimal.TryParse(leadTimeField.Text, out leadTime))
            {
                dataVendorSetup.LeadTime = leadTime;
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

        private void vendorLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataVendorSetup.VendorLocationCode = vendorLocationCodeField.Text;
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
            dataVendorSetup.VariantCode = variantCodeField.Text;
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
