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
    public partial class LocationSetupCard : Form
    {
        private dbContext dataContext = null;
        private LocationSetup dataLocationSetup = null;
        private IErrorHandler errorHandler;

        public LocationSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public LocationSetupCard(string locationCode)
            :this()
        {
            dataContext.LocationSetup.Load();
            dataLocationSetup = dataContext.LocationSetup.Where(u => u.LocationCode.Equals(locationCode)).FirstOrDefault();
            locationCodeField.Text = dataLocationSetup.LocationCode;
            descriptionField.Text = dataLocationSetup.Description;
            blockedCheckBox.Checked = dataLocationSetup.Blocked == null ? false : (bool)dataLocationSetup.Blocked;
            warehouseCheckBox.Checked = dataLocationSetup.Warehouse == null ? false : (bool)dataLocationSetup.Warehouse;
            address1Field.Text = dataLocationSetup.Address1;
            address2Field.Text = dataLocationSetup.Address2;
            cityField.Text = dataLocationSetup.City;
            zipCodeField.Text = dataLocationSetup.ZipCode;
            stateField.Text = dataLocationSetup.ZipCode;
            countryField.Text = dataLocationSetup.Country;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.LocationSetup.Remove(dataLocationSetup);
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
            dataLocationSetup.LocationCode = locationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataLocationSetup.Blocked = blockedCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void warehouseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataLocationSetup.Warehouse = warehouseCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void address1Field_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.Address1 = address1Field.Text;
            dataContext.SaveData(errorHandler);
        }

        private void address2Field_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.Address2 = address2Field.Text;
            dataContext.SaveData(errorHandler);
        }

        private void cityField_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.City = cityField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void zipCodeField_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.ZipCode = zipCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void stateField_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.State = stateField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void countryField_TextChanged(object sender, EventArgs e)
        {
            dataLocationSetup.Country = countryField.Text;
            dataContext.SaveData(errorHandler);
        }
    }
}
