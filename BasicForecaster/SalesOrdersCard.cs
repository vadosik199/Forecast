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

        public SalesOrdersCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public SalesOrdersCard(string salesOrderNo)
            :this()
        {
            dataContext.SalesOrders.Load();
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
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.CustomerCode = customerCodeField.Text;
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
            dataSalesOrders.Description = descriptionField.Text;
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
            dataSalesOrders.ItemCode = itemCodeField.Text;
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
            dataSalesOrders.ItemDescription = itemCodeField.Text;
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
            if (int.TryParse(salesOrderNoField.Text, out salesPrice))
            {
                dataSalesOrders.SalesPrice = salesPrice;
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

        private void quantityField_TextChanged(object sender, EventArgs e)
        {
            double quantity;
            if (double.TryParse(quantityField.Text, out quantity))
            {
                dataSalesOrders.Quantity = quantity;
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
            dataSalesOrders.UnitOfMeasure = unitOfMeasureField.Text;
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
            dataSalesOrders.VariantCode = variantCodeField.Text;
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
            dataSalesOrders.LocationCode = locationCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesOrders.CustomerLocationCode = customerLocationCodeField.Text;
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
            dataSalesOrders.ShipmentDate = shipmentDatePicker.Value;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesOrders.OrderDate = orderDatePicker.Value;
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
