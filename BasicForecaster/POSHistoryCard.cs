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
    public partial class POSHistoryCard : Form
    {
        private dbContext dataContext = null;
        private POSHistory dataPOSHistory = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public POSHistoryCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.POSHistory.Load();
            dataPOSHistory = new POSHistory();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public POSHistoryCard(double entryNo, Form parentForm)
            :this(parentForm)
        {
            
            dataPOSHistory = dataContext.POSHistory.Where(u => u.EntryNo.Equals(entryNo)).FirstOrDefault();
            entryNoField.Text = dataPOSHistory.EntryNo.ToString();
            storeNoField.Text = dataPOSHistory.StoreNo;
            storeNameField.Text = dataPOSHistory.StoreName;
            retailerField.Text = dataPOSHistory.Retailor;
            address1Field.Text = dataPOSHistory.Address1;
            address2Field.Text = dataPOSHistory.Address2;
            cityField.Text = dataPOSHistory.City;
            stateField.Text = dataPOSHistory.State;
            zipField.Text = dataPOSHistory.Zip;
            UPCCodeField.Text = dataPOSHistory.UPCCode;
            customerItemNoField.Text = dataPOSHistory.CustomerItemNo;
            itemCodeField.Text = dataPOSHistory.ItemCode;
            itemDescriptionField.Text = dataPOSHistory.ItemDescription;
            brandField.Text = dataPOSHistory.Brand;
            salesPriceField.Text = dataPOSHistory.SalesPrice == null ? "" : dataPOSHistory.SalesPrice.ToString();
            quantitySoldField.Text = dataPOSHistory.QuantitySold == null ? "" : dataPOSHistory.QuantitySold.ToString();
            unitOfMeasureField.Text = dataPOSHistory.UnitOfMeasure;
            saleDatePicker.Value = dataPOSHistory.SaleDate == null ? DateTime.Now : (DateTime)dataPOSHistory.SaleDate;
            customerIDField.Text = dataPOSHistory.CustomerID;
            variantCodeField.Text = dataPOSHistory.VariantCode;

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
                dataContext.POSHistory.Remove(dataPOSHistory);
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
            double entryNo;
            if (double.TryParse(entryNoField.Text, out entryNo))
            {
                dataPOSHistory.EntryNo = entryNo;
            }
            dataContext.SaveData(errorHandler);
        }

        private void storeNoField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.StoreNo = storeNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void storeNameField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.StoreName = storeNameField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void retailerField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Retailor = retailerField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void address1Field_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Address1 = address1Field.Text;
            dataContext.SaveData(errorHandler);
        }

        private void address2Field_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Address2 = address2Field.Text;
            dataContext.SaveData(errorHandler);
        }

        private void cityField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.City = cityField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void stateField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.State = stateField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void zipField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Zip = zipField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void UPCCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.UPCCode = UPCCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerItemNoField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.CustomerItemNo = customerItemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.ItemCode = itemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void itemDescriptionField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.ItemDescription = itemDescriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void brandField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.Brand = brandField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void salesPriceField_TextChanged(object sender, EventArgs e)
        {
            int salesPrice;
            if (int.TryParse(salesPriceField.Text, out salesPrice))
            {
                dataPOSHistory.SalesPrice = salesPrice;
            }
            dataContext.SaveData(errorHandler);
        }

        private void quantitySoldField_TextChanged(object sender, EventArgs e)
        {
            double quantitySold;
            if (double.TryParse(quantitySoldField.Text, out quantitySold))
            {
                dataPOSHistory.QuantitySold = quantitySold;
            }
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerIDField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.CustomerID = customerIDField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void variantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataPOSHistory.VariantCode = variantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void saleDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataPOSHistory.SaleDate = saleDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void POSHistoryCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            POSHistoryCard posHistory = new POSHistoryCard(this.parentForm, true);
            posHistory.Show();
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
                    double entryNo = double.Parse(entryNoField.Text);
                    if (context.POSHistory.Where(vs => vs.EntryNo == entryNo).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Entry No' = {entryNoField.Text} already exist!");
                    }
                    if (double.TryParse(entryNoField.Text, out entryNo))
                    {
                        dataPOSHistory.EntryNo = entryNo;
                    }
                    dataPOSHistory.StoreNo = storeNoField.Text;
                    dataPOSHistory.StoreName = storeNameField.Text;
                    dataPOSHistory.Retailor = retailerField.Text;
                    dataPOSHistory.Address1 = address1Field.Text;
                    dataPOSHistory.Address2 = address2Field.Text;
                    dataPOSHistory.City = cityField.Text;
                    dataPOSHistory.State = stateField.Text;
                    dataPOSHistory.Zip = zipField.Text;
                    dataPOSHistory.UPCCode = UPCCodeField.Text;
                    dataPOSHistory.CustomerItemNo = customerItemNoField.Text;
                    dataPOSHistory.ItemCode = itemCodeField.Text;
                    dataPOSHistory.ItemDescription = itemDescriptionField.Text;
                    dataPOSHistory.Brand = brandField.Text;
                    int salesPrice;
                    if (int.TryParse(salesPriceField.Text, out salesPrice))
                    {
                        dataPOSHistory.SalesPrice = salesPrice;
                    }
                    double quantitySold;
                    if (double.TryParse(quantitySoldField.Text, out quantitySold))
                    {
                        dataPOSHistory.QuantitySold = quantitySold;
                    }
                    dataPOSHistory.UnitOfMeasure = unitOfMeasureField.Text;
                    dataPOSHistory.CustomerID = customerIDField.Text;
                    dataPOSHistory.VariantCode = variantCodeField.Text;
                    dataPOSHistory.SaleDate = saleDatePicker.Value;
                    context.POSHistory.Add(dataPOSHistory);
                    context.SaveData(errorHandler);
                    POSHistoryCard newPOSHostoryCard = new POSHistoryCard(dataPOSHistory.EntryNo, parentForm);
                    newPOSHostoryCard.Show();
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
