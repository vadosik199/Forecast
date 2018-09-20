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
    public partial class CustomerBuyingCalendarCard : Form
    {
        private dbContext dataContext = null;
        private CustomerBuyingCalendar dataCustomerBuyingCalendar = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public CustomerBuyingCalendarCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public CustomerBuyingCalendarCard(string calendarCode, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.CustomerBuyingCalendar.Load();
            dataCustomerBuyingCalendar = dataContext.CustomerBuyingCalendar.Where(u => u.CalendarCode.Equals(calendarCode)).FirstOrDefault();
            calendarCodeField.Text = dataCustomerBuyingCalendar.CalendarCode;
            itemCodeField.Text = dataCustomerBuyingCalendar.ItemCode;
            itemCodeField.Text = dataCustomerBuyingCalendar.ItemDescription;
            quantityToBuyField.Text = dataCustomerBuyingCalendar.QuantityToBuy == null ? "" : dataCustomerBuyingCalendar.QuantityToBuy.ToString();
            unitOfMeasureField.Text = dataCustomerBuyingCalendar.UnitOfMeasure;
            customerLocationCodeField.Text = dataCustomerBuyingCalendar.CustomerLocationCode;
            variantCodeField.Text = dataCustomerBuyingCalendar.VariantCode;
            locationCodeField.Text = dataCustomerBuyingCalendar.LocationCode;
            orderDatePicker.Value = dataCustomerBuyingCalendar.OrderDate == null ? DateTime.Now : (DateTime)dataCustomerBuyingCalendar.OrderDate;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.CustomerBuyingCalendar.Remove(dataCustomerBuyingCalendar);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calendarCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.CalendarCode = calendarCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.ItemDescription = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void quantityToBuyField_TextChanged(object sender, EventArgs e)
        {
            double qtyToBuy;
            if (double.TryParse(quantityToBuyField.Text, out qtyToBuy))
            {
                dataCustomerBuyingCalendar.QuantityToBuy = qtyToBuy;
            }
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerLocationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.CustomerLocationCode = customerLocationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void locationCodeField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.LocationCode = locationCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void orderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCustomerBuyingCalendar.OrderDate = orderDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void CustomerBuyingCalendarCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
