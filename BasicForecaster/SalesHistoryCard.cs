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
    public partial class SalesHistoryCard : Form
    {
        private dbContext dataContext = null;
        private Sales_History dataSalesHistory = null;

        public SalesHistoryCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public SalesHistoryCard(int entryNo)
            :this()
        {
            dataContext.Sales_Histories.Load();
            dataSalesHistory = dataContext.Sales_Histories.Where(u => u.Entry_No == entryNo).FirstOrDefault();
            entryNoField.Text = dataSalesHistory.Entry_No.ToString();
            itemNoField.Text = dataSalesHistory.Item_No;
            itemDescriptionField.Text = dataSalesHistory.Item_Description;
            itemDescription2Field.Text = dataSalesHistory.Item_Description2;
            itemVariantField.Text = dataSalesHistory.Item_Variant;
            baseUnitOfMeasureField.Text = dataSalesHistory.Base_Unit_of_Measure;
            forecastUnitOfMeasureField.Text = dataSalesHistory.Forecast_Unit_of_Measure;
            typeField.Text = dataSalesHistory.Type;
            salesQuantityField.Text = dataSalesHistory.Sales_Quantity == null ? "" : dataSalesHistory.Sales_Quantity.ToString();
            returnQuantityField.Text = dataSalesHistory.Return_Quantity == null ? "" : dataSalesHistory.Return_Quantity.ToString();
            shipmentDatePicker.Value = dataSalesHistory.Shipment_Date == null ? DateTime.Now : (DateTime)dataSalesHistory.Shipment_Date;
            invoiceDatePicker.Value = dataSalesHistory.Invoice_Date == null ? DateTime.Now : (DateTime)dataSalesHistory.Invoice_Date;
            locationField.Text = dataSalesHistory.Location;
            itemCategoryField.Text = dataSalesHistory.Item_Category;
            salesQuantityFUOMField.Text = dataSalesHistory.Sales_Quantity___FUOM == null ? "" : dataSalesHistory.Sales_Quantity___FUOM.ToString();
            salesPriceField.Text = dataSalesHistory.Sales_Price == null ? "" : dataSalesHistory.Sales_Price.ToString();
            returnQuantityField.Text = dataSalesHistory.Return_Quantity == null ? "" : dataSalesHistory.Return_Quantity.ToString();
            itemLedEntryNoField.Text = dataSalesHistory.Item_Led__Entry_No == null ? "" : dataSalesHistory.Item_Led__Entry_No.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.Sales_Histories.Remove(dataSalesHistory);
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
            int entryNo;
            if (int.TryParse(entryNoField.Text, out entryNo))
            {
                dataSalesHistory.Entry_No = entryNo;
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

        private void itemNoField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_No = itemNoField.Text;
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
            dataSalesHistory.Item_Description = itemDescriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemDescription2Field_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Description2 = itemDescription2Field.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemVariantField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Variant = itemVariantField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void baseUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Base_Unit_of_Measure = baseUnitOfMeasureField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void forecastUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Forecast_Unit_of_Measure = forecastUnitOfMeasureField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void typeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Type = typeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salesQuantityField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesQuantityField.Text, out qty))
            {
                dataSalesHistory.Sales_Quantity = qty;
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

        private void returnQuantityField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(returnQuantityField.Text, out qty))
            {
                dataSalesHistory.Return_Quantity = qty;
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

        private void salesQuantityFUOMField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesQuantityFUOMField.Text, out qty))
            {
                dataSalesHistory.Sales_Quantity___FUOM = qty;
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

        private void salesPriceField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesPriceField.Text, out qty))
            {
                dataSalesHistory.Sales_Price = qty;
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

        private void salesDiscountField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesDiscountField.Text, out qty))
            {
                dataSalesHistory.Sales_Discount = qty;
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

        private void itemLedEntryNoField_TextChanged(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(itemLedEntryNoField.Text, out no))
            {
                dataSalesHistory.Item_Led__Entry_No = no;
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

        private void itemCategoryField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Category = itemCategoryField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void locationField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Location = locationField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void invoiceDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Invoice_Date = invoiceDatePicker.Value;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void shipmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Shipment_Date = shipmentDatePicker.Value;
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
