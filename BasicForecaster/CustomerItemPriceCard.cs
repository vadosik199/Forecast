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
    public partial class CustomerItemPriceCard : Form
    {
        private dbContext dataContext = null;
        private CustomerItemPrice dataCustomerItemPrice = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public CustomerItemPriceCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public CustomerItemPriceCard(string itemNo, string customerCode, DateTime startDate, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.CustomerItemPrice.Load();
            dataCustomerItemPrice = dataContext.CustomerItemPrice.Where(u => u.ItemNo.Equals(itemNo) && u.CustomerCode.Equals(customerCode) && u.StartDate == startDate).FirstOrDefault();
            itemNoField.Text = dataCustomerItemPrice.ItemNo;
            descriptionField.Text = dataCustomerItemPrice.Description;
            customerCodeField.Text = dataCustomerItemPrice.CustomerCode;
            customerDescriptionField.Text = dataCustomerItemPrice.CustomerDescription;
            unitPriceField.Text = dataCustomerItemPrice.UnitPrice == null ? "" : dataCustomerItemPrice.UnitPrice.ToString();
            minimumQtyField.Text = dataCustomerItemPrice.MinimumQty == null ? "" : dataCustomerItemPrice.MinimumQty.ToString();
            startDatePicker.Value = dataCustomerItemPrice.StartDate == null ? DateTime.Now : (DateTime)dataCustomerItemPrice.StartDate;
            endDatePicker.Value = dataCustomerItemPrice.EndDate == null ? DateTime.Now : (DateTime)dataCustomerItemPrice.EndDate;
            unitOfMeasureField.Text = dataCustomerItemPrice.UnitOfMeasure;
            variantCodeField.Text = dataCustomerItemPrice.VariantCode;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.CustomerItemPrice.Remove(dataCustomerItemPrice);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemNoField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.ItemNo = itemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.CustomerCode = customerCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.CustomerDescription = customerDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void unitPriceField_TextChanged(object sender, EventArgs e)
        {
            int unitPrice;
            if (int.TryParse(unitPriceField.Text, out unitPrice))
            {
                dataCustomerItemPrice.UnitPrice = unitPrice;
            }
            dataContext.SaveData(errorHandler);
        }

        private void minimumQtyField_TextChanged(object sender, EventArgs e)
        {
            double minQty;
            if (double.TryParse(minimumQtyField.Text, out minQty))
            {
                dataCustomerItemPrice.MinimumQty = minQty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.StartDate = startDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.EndDate = endDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void CustomerItemPriceCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
