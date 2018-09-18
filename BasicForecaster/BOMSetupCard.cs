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

        public BOMSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
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
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lineNoField_TextChanged(object sender, EventArgs e)
        {
            int lineNo;
            if (int.TryParse(lineNoField.Text, out lineNo))
            {
                dataBOMSetup.LineNo = lineNo;
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

        private void bomItemNoField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMItemNo = bomItemNoField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bomVariantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMVariantCode = bomVariantCodeField.Text;
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
            dataBOMSetup.Description = descriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bomUnitOfMeasureCodeField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.BOMUnitOfMeasureCode = bomUnitOfMeasureCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bomQuantityField_TextChanged(object sender, EventArgs e)
        {
            double bomQty;
            if (double.TryParse(bomQuantityField.Text, out bomQty))
            {
                dataBOMSetup.BOMQuantity = bomQty;
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

        private void compItemNoField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.CompItemNo = compItemNoField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void compVariantCodeField_TextChanged(object sender, EventArgs e)
        {
            dataBOMSetup.CompVariantCode = compVariantCodeField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quantityPerField_TextChanged(object sender, EventArgs e)
        {
            double bomQty;
            if (double.TryParse(quantityPerField.Text, out bomQty))
            {
                dataBOMSetup.QuantityPer = bomQty;
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

        private void quantityPerBaseField_TextChanged(object sender, EventArgs e)
        {
            double bomQty;
            if (double.TryParse(quantityPerBaseField.Text, out bomQty))
            {
                dataBOMSetup.QuantityPerBase = bomQty;
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
    }
}
