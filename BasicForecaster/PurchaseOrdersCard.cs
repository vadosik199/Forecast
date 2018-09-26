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
        private Form parentForm;
        public bool IsNew { get; private set; }

        public PurchaseOrdersCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.PurchaseOrders.Load();
            dataPurchaseOrders = new PurchaseOrders();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public PurchaseOrdersCard(string purchaseOrderNo, Form parentForm)
            :this(parentForm)
        {
            
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

            if (!IsNew)
            {
                purchaseOrderNoField.Enabled = false;
                SaveButton.Visible = false;
            }
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

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void PurchaseOrdersCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            PurchaseOrdersCard purchaseOrder = new PurchaseOrdersCard(parentForm, true);
            purchaseOrder.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(purchaseOrderNoField.Text))
                    {
                        throw new Exception("Field 'Purchase Order No' can`t be empty!");
                    }
                    if (context.PurchaseOrders.Where(vs => vs.PurchaseOrderNo.Equals(purchaseOrderNoField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Purchase Order No' = {purchaseOrderNoField.Text} already exist!");
                    }
                    dataPurchaseOrders.PurchaseOrderNo = purchaseOrderNoField.Text;
                    dataPurchaseOrders.VendorNo = vendorNoField.Text;
                    dataPurchaseOrders.Description = descriptionField.Text;
                    dataPurchaseOrders.ItemCode = itemCodeField.Text;
                    dataPurchaseOrders.ItemDescription = itemDescriptionField.Text;
                    int purchasePrice;
                    if (int.TryParse(purchasePriceField.Text, out purchasePrice))
                    {
                        dataPurchaseOrders.PurchasePrice = purchasePrice;
                    }
                    double quantity;
                    if (double.TryParse(quantityField.Text, out quantity))
                    {
                        dataPurchaseOrders.Quantity = quantity;
                    }
                    dataPurchaseOrders.UnitOfMeasure = unitOfMeasureField.Text;
                    dataPurchaseOrders.VariantCode = variantCodeField.Text;
                    dataPurchaseOrders.LocationCode = locationCodeField.Text;
                    dataPurchaseOrders.VendorLocationCode = vendorLocationCodeField.Text;
                    dataPurchaseOrders.ExpectedReceiptDate = expectedReceiptDatePicker.Value;
                    dataPurchaseOrders.OrderDate = orderDatePicker.Value;
                    context.PurchaseOrders.Add(dataPurchaseOrders);
                    context.SaveData(errorHandler);
                    PurchaseOrdersCard newPurchaseOrderCard = new PurchaseOrdersCard(dataPurchaseOrders.PurchaseOrderNo, parentForm);
                    newPurchaseOrderCard.Show();
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
