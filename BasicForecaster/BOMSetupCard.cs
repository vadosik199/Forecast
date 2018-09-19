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
    public partial class BOMSetupCard : Form
    {
        private dbContext dataContext = null;
        private BOMSetup dataBOMSetup = null;
        private IErrorHandler errorHandler;

        public BOMSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public BOMSetupCard(string bomNo)
            :this()
        {
            dataContext.BOMSetup.Load();
            dataBOMSetup = dataContext.BOMSetup.Where(u => u.BOMNo.Equals(bomNo)).FirstOrDefault();
            bomNoField.Text = dataBOMSetup.BOMNo;
            lineNoField.Text = dataBOMSetup.LineNo == null ? "" : dataBOMSetup.LineNo.ToString();
            bomItemNoField.Text = dataBOMSetup.BOMItemNo;
            bomVariantCodeField.Text = dataBOMSetup.BOMVariantCode;
            descriptionField.Text = dataBOMSetup.Description;
            bomUnitOfMeasureCodeField.Text = dataBOMSetup.BOMUnitOfMeasureCode;
            bomQuantityField.Text = dataBOMSetup.BOMQuantity == null ? "" : dataBOMSetup.BOMQuantity.ToString();
            compItemNoField.Text = dataBOMSetup.CompItemNo;
            quantityPerField.Text = dataBOMSetup.QuantityPer == null ? "" : dataBOMSetup.QuantityPer.ToString();
            quantityPerBaseField.Text = dataBOMSetup.QuantityPerBase == null ? "" : dataBOMSetup.QuantityPerBase.ToString();
            compVariantCodeField.Text = dataBOMSetup.CompVariantCode;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.BOMSetup.Remove(dataBOMSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bomNoField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMNo = bomNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void lineNoField_TextChanged(object sender, EventArgs e)
        {
            int lineNo;
            if (int.TryParse(lineNoField.Text, out lineNo))
            {
                dataBOMSetup.LineNo = lineNo;
            }
            dataContext.SaveData(errorHandler);
        }

        private void bomItemNoField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMItemNo = bomItemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void bomVariantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMVariantCode = bomVariantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void bomUnitOfMeasureCodeField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMUnitOfMeasureCode = bomUnitOfMeasureCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void bomQuantityField_TextChanged(object sender, EventArgs e)
        {
            double bomQty;
            if (double.TryParse(bomQuantityField.Text, out bomQty))
            {
                dataBOMSetup.BOMQuantity = bomQty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void compItemNoField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.CompItemNo = compItemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void compVariantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.CompVariantCode = compVariantCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void quantityPerField_TextChanged(object sender, EventArgs e)
        {
            double bomQty;
            if (double.TryParse(quantityPerField.Text, out bomQty))
            {
                dataBOMSetup.QuantityPer = bomQty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void quantityPerBaseField_TextChanged(object sender, EventArgs e)
        {
            double bomQty;
            if (double.TryParse(quantityPerBaseField.Text, out bomQty))
            {
                dataBOMSetup.QuantityPerBase = bomQty;
            }
            dataContext.SaveData(errorHandler);
        }
    }
}
