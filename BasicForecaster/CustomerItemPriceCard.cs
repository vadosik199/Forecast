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

        public CustomerItemPriceCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public CustomerItemPriceCard(string itemNo, string customerCode, DateTime startDate)
            :this()
        {
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
            dataCustomerItemPrice.Description = descriptionField.Text;
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
            dataCustomerItemPrice.CustomerCode = customerCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.CustomerDescription = customerDescriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unitPriceField_TextChanged(object sender, EventArgs e)
        {
            int unitPrice;
            if (int.TryParse(unitPriceField.Text, out unitPrice))
            {
                dataCustomerItemPrice.UnitPrice = unitPrice;
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

        private void minimumQtyField_TextChanged(object sender, EventArgs e)
        {
            double minQty;
            if (double.TryParse(minimumQtyField.Text, out minQty))
            {
                dataCustomerItemPrice.MinimumQty = minQty;
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
            dataCustomerItemPrice.UnitOfMeasure = unitOfMeasureField.Text;
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
            dataCustomerItemPrice.VariantCode = variantCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.StartDate = startDatePicker.Value;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCustomerItemPrice.EndDate = endDatePicker.Value;
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
