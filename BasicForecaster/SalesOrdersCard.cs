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
    public partial class SalesOrdersCard : Form
    {
        private dbContext dataContext = null;
        private SalesOrders dataSalesOrders = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public SalesOrdersCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
            dataSalesOrders = new SalesOrders();
            dataContext.SalesOrders.Load();
            this.parentForm = parentForm;
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public SalesOrdersCard(string salesOrderNo, Form parentForm)
            :this(parentForm)
        {
            dataSalesOrders = dataContext.SalesOrders.Where(u => u.SalesOrderNo.Equals(salesOrderNo)).FirstOrDefault();
            salesOrderNoField.Text = dataSalesOrders.SalesOrderNo;
            customerCodeField.Text = dataSalesOrders.CustomerCode;
            descriptionField.Text = dataSalesOrders.Description;
            itemCodeField.Text = dataSalesOrders.ItemCode;
            itemDescriptionField.Text = dataSalesOrders.ItemDescription;
            salesPriceField.Text = dataSalesOrders.SalesPrice == null ? "" : dataSalesOrders.SalesPrice.ToString();
            quantityField.Text = dataSalesOrders.Quantity == null ? "" : dataSalesOrders.Quantity.ToString();
            unitOfMeasureField.Text = dataSalesOrders.UnitOfMeasure;
            shipmentDatePicker.Value = dataSalesOrders.ShipmentDate == null ? DateTime.Now : (DateTime)dataSalesOrders.ShipmentDate;
            variantCodeField.Text = dataSalesOrders.VariantCode;
            locationCodeField.Text = dataSalesOrders.LocationCode;
            customerLocationCodeField.Text = dataSalesOrders.CustomerLocationCode;
            orderDatePicker.Value = dataSalesOrders.OrderDate == null ? DateTime.Now : (DateTime)dataSalesOrders.OrderDate;

            if (!IsNew)
            {
                salesOrderNoField.Enabled = false;
                SaveButton.Visible = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.SalesOrders.Remove(dataSalesOrders);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salesOrderNoField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.SalesOrderNo = salesOrderNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.CustomerCode = customerCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.ItemDescription = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void salesPriceField_TextChanged(object sender, EventArgs e)
        {
            int salesPrice;
            if (int.TryParse(salesPriceField.Text, out salesPrice))
            {
                dataSalesOrders.SalesPrice = salesPrice;
            }
            dataContext.SaveData(errorHandler);
        }

        private void quantityField_TextChanged(object sender, EventArgs e)
        {
            double quantity;
            if (double.TryParse(quantityField.Text, out quantity))
            {
                dataSalesOrders.Quantity = quantity;
            }
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void locationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.LocationCode = locationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.CustomerLocationCode = customerLocationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void shipmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesOrders.ShipmentDate = shipmentDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void orderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesOrders.OrderDate = orderDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void SalesOrdersCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SalesOrdersCard salesOrder = new SalesOrdersCard(parentForm, true);
            salesOrder.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(salesOrderNoField.Text))
                    {
                        throw new Exception("Field 'Sales Order No' can`t be empty!");
                    }
                    if (context.SalesOrders.Where(vs => vs.SalesOrderNo.Equals(salesOrderNoField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Sales Order No' = {salesOrderNoField.Text} already exist!");
                    }
                    dataSalesOrders.SalesOrderNo = salesOrderNoField.Text;
                    dataSalesOrders.CustomerCode = customerCodeField.Text;
                    dataSalesOrders.Description = descriptionField.Text;
                    dataSalesOrders.ItemCode = itemCodeField.Text;
                    dataSalesOrders.ItemDescription = itemCodeField.Text;
                    int salesPrice;
                    if (int.TryParse(salesPriceField.Text, out salesPrice))
                    {
                        dataSalesOrders.SalesPrice = salesPrice;
                    }
                    double quantity;
                    if (double.TryParse(quantityField.Text, out quantity))
                    {
                        dataSalesOrders.Quantity = quantity;
                    }
                    dataSalesOrders.UnitOfMeasure = unitOfMeasureField.Text;
                    dataSalesOrders.VariantCode = variantCodeField.Text;
                    dataSalesOrders.LocationCode = locationCodeField.Text;
                    dataSalesOrders.CustomerLocationCode = customerLocationCodeField.Text;
                    dataSalesOrders.ShipmentDate = shipmentDatePicker.Value;
                    dataSalesOrders.OrderDate = orderDatePicker.Value;
                    context.SalesOrders.Add(dataSalesOrders);
                    context.SaveData(errorHandler);
                    SalesOrdersCard newSalesOrderCard = new SalesOrdersCard(dataSalesOrders.SalesOrderNo, parentForm);
                    newSalesOrderCard.Show();
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
