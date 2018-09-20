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
    public partial class SalesPriceChangeHistoryCard : Form
    {
        private dbContext dataContext = null;
        private SalesPriceChangeHistory dataSalesPriceChangeHistory = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public SalesPriceChangeHistoryCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public SalesPriceChangeHistoryCard(string entryNo, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.SalesPriceChangeHistory.Load();
            dataSalesPriceChangeHistory = dataContext.SalesPriceChangeHistory.Where(u => u.EntryNo.Equals(entryNo)).FirstOrDefault();
            entryNoField.Text = dataSalesPriceChangeHistory.EntryNo;
            itemNoField.Text = dataSalesPriceChangeHistory.ItemNo;
            descriptionField.Text = dataSalesPriceChangeHistory.Description;
            customerCodeField.Text = dataSalesPriceChangeHistory.CustomerCode;
            customerDescriptionField.Text = dataSalesPriceChangeHistory.CustomerDescription;
            salesPriceField.Text = dataSalesPriceChangeHistory.SalesPrice == null ? "" : dataSalesPriceChangeHistory.SalesPrice.ToString();
            unitOfMeasureField.Text = dataSalesPriceChangeHistory.UnitOfMeasure;
            shipmentDateDatePicker.Value = dataSalesPriceChangeHistory.ShipmentDate == null ? DateTime.Now : (DateTime)dataSalesPriceChangeHistory.ShipmentDate;
            variantCodeField.Text = dataSalesPriceChangeHistory.VariantCode;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.SalesPriceChangeHistory.Remove(dataSalesPriceChangeHistory);
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
            dataSalesPriceChangeHistory.EntryNo = entryNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemNoField_TextChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.ItemNo = itemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.CustomerCode = customerCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.CustomerDescription = customerDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void salesPriceField_TextChanged(object sender, EventArgs e)
        {
            int salesPrice;
            if (int.TryParse(salesPriceField.Text, out salesPrice))
            {
                dataSalesPriceChangeHistory.SalesPrice = salesPrice;
            }
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void shipmentDateDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesPriceChangeHistory.ShipmentDate = shipmentDateDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void SalesPriceChangeHistoryCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
