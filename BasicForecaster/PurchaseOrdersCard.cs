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
    public partial class PurchaseOrdersCard : Form
    {
        private dbContext dataContext = null;
        private PurchaseOrders dataPurchaseOrders = null;
        private IErrorHandler errorHandler;

        public PurchaseOrdersCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public PurchaseOrdersCard(string purchaseOrderNo)
            :this()
        {
            dataContext.PurchaseOrders.Load();
            dataPurchaseOrders = dataContext.PurchaseOrders.Where(u => u.PurchaseOrderNo.Equals(purchaseOrderNo)).FirstOrDefault();
            purchaseOrderNoField.Text = dataPurchaseOrders.PurchaseOrderNo;
            vendorLocationCodeField.Text = dataPurchaseOrders.VendorNo;
            descriptionField.Text = dataPurchaseOrders.Description;
            itemCodeField.Text = dataPurchaseOrders.ItemCode;
            itemDescriptionField.Text = dataPurchaseOrders.ItemDescription;
            purchasePriceField.Text = dataPurchaseOrders.PurchasePrice == null ? "" : dataPurchaseOrders.PurchasePrice.ToString();
            quantityField.Text = dataPurchaseOrders.Quantity == null ? "" : dataPurchaseOrders.Quantity.ToString();
            unitOfMeasureField.Text = dataPurchaseOrders.UnitOfMeasure;
            expectedReceiptDatePicker.Value = dataPurchaseOrders.ExpectedReceiptDate == null ? DateTime.Now : (DateTime)dataPurchaseOrders.ExpectedReceiptDate;
            locationCodeField.Text = dataPurchaseOrders.LocationCode;
            variantCodeField.Text = dataPurchaseOrders.VariantCode;
            vendorLocationCodeField.Text = dataPurchaseOrders.VendorLocationCode;
            orderDatePicker.Value = dataPurchaseOrders.OrderDate == null ? DateTime.Now : (DateTime)dataPurchaseOrders.OrderDate;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.PurchaseOrders.Remove(dataPurchaseOrders);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void purchaseOrderNoField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.PurchaseOrderNo = purchaseOrderNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void vendorNoField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.VendorNo = vendorNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.ItemDescription = itemDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void purchasePriceField_TextChanged(object sender, EventArgs e)
        {
            int purchasePrice;
            if (int.TryParse(purchasePriceField.Text, out purchasePrice))
            {
                dataPurchaseOrders.PurchasePrice = purchasePrice;
            }
            dataContext.SaveData(errorHandler);
        }

        private void quantityField_TextChanged(object sender, EventArgs e)
        {
            double quantity;
            if (double.TryParse(quantityField.Text, out quantity))
            {
                dataPurchaseOrders.Quantity = quantity;
            }
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void locationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.LocationCode = locationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void vendorLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.VendorLocationCode = vendorLocationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void expectedReceiptDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.ExpectedReceiptDate = expectedReceiptDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void orderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataPurchaseOrders.OrderDate = orderDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }
    }
}
