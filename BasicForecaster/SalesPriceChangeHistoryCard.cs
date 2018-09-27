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
        public bool IsNew { get; private set; }

        public SalesPriceChangeHistoryCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataContext = new dbContext();
            dataSalesPriceChangeHistory = new SalesPriceChangeHistory();
            errorHandler = new WinFormErrorHandler();
            dataContext.SalesPriceChangeHistory.Load();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public SalesPriceChangeHistoryCard(string entryNo, Form parentForm)
            :this(parentForm)
        {
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

            if (!IsNew)
            {
                entryNoField.Enabled = false;
                SaveButton.Visible = false;
            }
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

        private void NewButton_Click(object sender, EventArgs e)
        {
            SalesPriceChangeHistoryCard salesPriceChangeHistoryCard = new SalesPriceChangeHistoryCard(parentForm, true);
            salesPriceChangeHistoryCard.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(entryNoField.Text))
                    {
                        throw new Exception("Field 'Entry No' can`t be empty!");
                    }
                    if (context.SalesPriceChangeHistory.Where(vs => vs.EntryNo.Equals(entryNoField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Vendor No' = {entryNoField.Text} already exist!");
                    }
                    dataSalesPriceChangeHistory.EntryNo = entryNoField.Text;
                    dataSalesPriceChangeHistory.ItemNo = itemNoField.Text;
                    dataSalesPriceChangeHistory.Description = descriptionField.Text;
                    dataSalesPriceChangeHistory.CustomerCode = customerCodeField.Text;
                    dataSalesPriceChangeHistory.CustomerDescription = customerDescriptionField.Text;
                    int salesPrice;
                    if (int.TryParse(salesPriceField.Text, out salesPrice))
                    {
                        dataSalesPriceChangeHistory.SalesPrice = salesPrice;
                    }
                    dataSalesPriceChangeHistory.UnitOfMeasure = unitOfMeasureField.Text;
                    dataSalesPriceChangeHistory.VariantCode = variantCodeField.Text;
                    dataSalesPriceChangeHistory.ShipmentDate = shipmentDateDatePicker.Value;
                    context.SalesPriceChangeHistory.Add(dataSalesPriceChangeHistory);
                    context.SaveData(errorHandler);
                    SalesPriceChangeHistoryCard newSalesPriceChange = new SalesPriceChangeHistoryCard(dataSalesPriceChangeHistory.EntryNo, parentForm);
                    newSalesPriceChange.Show();
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
