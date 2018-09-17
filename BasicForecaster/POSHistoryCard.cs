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
    public partial class POSHistoryCard : Form
    {
        private dbContext dataContext = null;
        private POSHistory dataPOSHistory = null;

        public POSHistoryCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public POSHistoryCard(double entryNo)
            :this()
        {
            dataContext.POSHistory.Load();
            dataPOSHistory = dataContext.POSHistory.Where(u => u.EntryNo.Equals(entryNo)).FirstOrDefault();
            entryNoField.Text = dataPOSHistory.EntryNo.ToString();
            storeNoField.Text = dataPOSHistory.StoreNo;
            storeNameField.Text = dataPOSHistory.StoreName;
            retailerField.Text = dataPOSHistory.Retailor;
            address1Field.Text = dataPOSHistory.Address1;
            address2Field.Text = dataPOSHistory.Address2;
            cityField.Text = dataPOSHistory.City;
            stateField.Text = dataPOSHistory.State;
            zipField.Text = dataPOSHistory.Zip;
            UPCCodeField.Text = dataPOSHistory.UPCCode;
            customerItemNoField.Text = dataPOSHistory.CustomerItemNo;
            itemCodeField.Text = dataPOSHistory.ItemCode;
            itemDescriptionField.Text = dataPOSHistory.ItemDescription;
            brandField.Text = dataPOSHistory.Brand;
            salesPriceField.Text = dataPOSHistory.SalesPrice == null ? "" : dataPOSHistory.SalesPrice.ToString();
            quantitySoldField.Text = dataPOSHistory.QuantitySold == null ? "" : dataPOSHistory.QuantitySold.ToString();
            unitOfMeasureField.Text = dataPOSHistory.UnitOfMeasure;
            saleDatePicker.Value = dataPOSHistory.SaleDate == null ? DateTime.Now : (DateTime)dataPOSHistory.SaleDate;
            customerIDField.Text = dataPOSHistory.CustomerID;
            variantCodeField.Text = dataPOSHistory.VariantCode;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.POSHistory.Remove(dataPOSHistory);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void entryNoField_TextChanged(object sender, EventArgs e)
        {
            double entryNo;
            if (double.TryParse(entryNoField.Text, out entryNo))
            {
                dataPOSHistory.EntryNo = entryNo;
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

        private void storeNoField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.StoreNo = storeNameField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void storeNameField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.StoreName = storeNameField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retailerField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Retailor = retailerField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void address1Field_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Address1 = address1Field.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void address2Field_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Address2 = address2Field.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cityField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.City = cityField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stateField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.State = stateField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zipField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Zip = zipField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UPCCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.UPCCode = UPCCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerItemNoField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.CustomerItemNo = customerItemNoField.Text;
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
            dataPOSHistory.ItemCode = itemCodeField.Text;
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
            dataPOSHistory.ItemDescription = itemCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brandField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Brand = brandField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salesPriceField_TextChanged(object sender, EventArgs e)
        {
            int salesPrice;
            if (int.TryParse(salesPriceField.Text, out salesPrice))
            {
                dataPOSHistory.SalesPrice = salesPrice;
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

        private void quantitySoldField_TextChanged(object sender, EventArgs e)
        {
            double quantitySold;
            if (double.TryParse(quantitySoldField.Text, out quantitySold))
            {
                dataPOSHistory.QuantitySold = quantitySold;
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

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.UnitOfMeasure = unitOfMeasureField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerIDField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.CustomerID = customerIDField.Text;
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
            dataPOSHistory.VariantCode = variantCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saleDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataPOSHistory.SaleDate = saleDatePicker.Value;
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
