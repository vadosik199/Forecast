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
    public partial class SalesHistoryCard : Form
    {
        private dbContext dataContext = null;
        private Sales_History dataSalesHistory = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public SalesHistoryCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.Sales_Histories.Load();
            dataSalesHistory = new Sales_History();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public SalesHistoryCard(int entryNo, Form parentForm)
            :this(parentForm)
        {
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
            dataContext.SaveData(errorHandler);
        }

        private void itemNoField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_No = itemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Description = itemDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescription2Field_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Description2 = itemDescription2Field.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemVariantField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Variant = itemVariantField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void baseUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Base_Unit_of_Measure = baseUnitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void forecastUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Forecast_Unit_of_Measure = forecastUnitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void typeField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Type = typeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void salesQuantityField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesQuantityField.Text, out qty))
            {
                dataSalesHistory.Sales_Quantity = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void returnQuantityField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(returnQuantityField.Text, out qty))
            {
                dataSalesHistory.Return_Quantity = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void salesQuantityFUOMField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesQuantityFUOMField.Text, out qty))
            {
                dataSalesHistory.Sales_Quantity___FUOM = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void salesPriceField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesPriceField.Text, out qty))
            {
                dataSalesHistory.Sales_Price = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void salesDiscountField_TextChanged(object sender, EventArgs e)
        {
            decimal qty;
            if (decimal.TryParse(salesDiscountField.Text, out qty))
            {
                dataSalesHistory.Sales_Discount = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void itemLedEntryNoField_TextChanged(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(itemLedEntryNoField.Text, out no))
            {
                dataSalesHistory.Item_Led__Entry_No = no;
            }
            dataContext.SaveData(errorHandler);
        }

        private void itemCategoryField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Item_Category = itemCategoryField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void locationField_TextChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Location = locationField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void invoiceDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Invoice_Date = invoiceDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void shipmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataSalesHistory.Shipment_Date = shipmentDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void SalesHistoryCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SalesHistoryCard salesHistory = new SalesHistoryCard(parentForm, true);
            salesHistory.Show();
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
                    int entryN = int.Parse(entryNoField.Text);
                    if (context.Sales_Histories.Where(vs => vs.Entry_No == entryN).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Entry No' = {entryNoField.Text} already exist!");
                    }
                    int entryNo;
                    if (int.TryParse(entryNoField.Text, out entryNo))
                    {
                        dataSalesHistory.Entry_No = entryNo;
                    }
                    dataSalesHistory.Item_No = itemNoField.Text;
                    dataSalesHistory.Item_Description = itemDescriptionField.Text;
                    dataSalesHistory.Item_Variant = itemVariantField.Text;
                    dataSalesHistory.Item_Description2 = itemDescription2Field.Text;
                    dataSalesHistory.Base_Unit_of_Measure = baseUnitOfMeasureField.Text;
                    dataSalesHistory.Forecast_Unit_of_Measure = forecastUnitOfMeasureField.Text;
                    dataSalesHistory.Type = typeField.Text;
                    decimal qty;
                    if (decimal.TryParse(salesQuantityField.Text, out qty))
                    {
                        dataSalesHistory.Sales_Quantity = qty;
                    }
                    if (decimal.TryParse(returnQuantityField.Text, out qty))
                    {
                        dataSalesHistory.Return_Quantity = qty;
                    }
                    if (decimal.TryParse(salesQuantityFUOMField.Text, out qty))
                    {
                        dataSalesHistory.Sales_Quantity___FUOM = qty;
                    }
                    if (decimal.TryParse(salesPriceField.Text, out qty))
                    {
                        dataSalesHistory.Sales_Price = qty;
                    }
                    if (decimal.TryParse(salesDiscountField.Text, out qty))
                    {
                        dataSalesHistory.Sales_Discount = qty;
                    }
                    int no;
                    if (int.TryParse(itemLedEntryNoField.Text, out no))
                    {
                        dataSalesHistory.Item_Led__Entry_No = no;
                    }
                    dataSalesHistory.Item_Category = itemCategoryField.Text;
                    dataSalesHistory.Location = locationField.Text;
                    dataSalesHistory.Invoice_Date = invoiceDatePicker.Value;
                    dataSalesHistory.Shipment_Date = shipmentDatePicker.Value;
                    context.Sales_Histories.Add(dataSalesHistory);
                    context.SaveChanges();
                    SalesHistoryCard newSalesHistoryCard = new SalesHistoryCard(dataSalesHistory.Entry_No, parentForm);
                    newSalesHistoryCard.Show();
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
