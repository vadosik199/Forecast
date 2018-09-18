﻿using BasicForecaster.Models;
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
    public partial class AssemblyProductionOrdersCard : Form
    {
        private dbContext dataContext = null;
        private AssemblyOrdersProductionOrders dataAssemblyProductionPrders = null;

        public AssemblyProductionOrdersCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public AssemblyProductionOrdersCard(string productionOrderNo)
            :this()
        {
            dataContext.AssemblyOrdersProductionOrders.Load();
            dataAssemblyProductionPrders = dataContext.AssemblyOrdersProductionOrders.Where(u => u.ProductionOrderNo.Equals(productionOrderNo)).FirstOrDefault();
            productionOrderNoField.Text = dataAssemblyProductionPrders.ProductionOrderNo;
            itemCodeField.Text = dataAssemblyProductionPrders.ItemCode;
            itemDescriptionField.Text = dataAssemblyProductionPrders.ItemDescription;
            quantityToMakeField.Text = dataAssemblyProductionPrders.QuantityToMake == null ? "" : dataAssemblyProductionPrders.QuantityToMake.ToString();
            unitOfMeasureField.Text = dataAssemblyProductionPrders.UnitOfMeasure;
            expectedCompletionDatePicker.Value = dataAssemblyProductionPrders.ExpectedCompletionDate == null ? DateTime.Now : (DateTime)dataAssemblyProductionPrders.ExpectedCompletionDate;
            variantCodeField.Text = dataAssemblyProductionPrders.VariantCode;
            locationCodeField.Text = dataAssemblyProductionPrders.LocationCode;
            orderDatePicker.Value = dataAssemblyProductionPrders.OrderDate == null ? DateTime.Now : (DateTime)dataAssemblyProductionPrders.OrderDate;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.AssemblyOrdersProductionOrders.Remove(dataAssemblyProductionPrders);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productionOrderNoField_TextChanged(object sender, EventArgs e)
        {
            dataAssemblyProductionPrders.ProductionOrderNo = productionOrderNoField.Text;
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
            dataAssemblyProductionPrders.ItemCode = itemCodeField.Text;
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
            dataAssemblyProductionPrders.ItemDescription = itemDescriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quantityToMakeField_TextChanged(object sender, EventArgs e)
        {
            double qty;
            if (double.TryParse(quantityToMakeField.Text, out qty))
            {
                dataAssemblyProductionPrders.QuantityToMake = qty;
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
            dataAssemblyProductionPrders.UnitOfMeasure = unitOfMeasureField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void expectedCompletionDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataAssemblyProductionPrders.ExpectedCompletionDate = expectedCompletionDatePicker.Value;
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
            dataAssemblyProductionPrders.VariantCode = variantCodeField.Text;
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
            dataAssemblyProductionPrders.LocationCode = locationCodeField.Text;
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
            dataAssemblyProductionPrders.OrderDate = orderDatePicker.Value;
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
