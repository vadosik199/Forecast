﻿using BasicForecaster.Interfaces;
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
    public partial class ForecastSetupCard : Form
    {
        private dbContext dataContext = null;
        private ForecastSetup dataForecastSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public ForecastSetupCard()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
            errorHandler = new WinFormErrorHandler();
        }

        public ForecastSetupCard(string code, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.ForecastSetup.Load();
            dataForecastSetup = dataContext.ForecastSetup.Where(u => u.Code.Equals(code)).FirstOrDefault();
            codeField.Text = dataForecastSetup.Code;
            descriptionField.Text = dataForecastSetup.Description;
            alphaFactorField.Text = dataForecastSetup.AlphaFactor == null ? "" : dataForecastSetup.AlphaFactor.ToString();
            betaFactorField.Text = dataForecastSetup.BetaFactor == null ? "" : dataForecastSetup.BetaFactor.ToString();
            gammaFactorField.Text = dataForecastSetup.GammaFactor == null ? "" : dataForecastSetup.GammaFactor.ToString();
            deltaFactorField.Text = dataForecastSetup.DeltaFactor == null ? "" : dataForecastSetup.DeltaFactor.ToString();
            factorOptimizationCheckBox.Checked = dataForecastSetup.FactorOptimization == null ? false : (bool)dataForecastSetup.FactorOptimization;
            rankingField.Text = dataForecastSetup.Ranking == null ? "" : dataForecastSetup.Ranking.ToString();
            simpleMAPeriodInMonthField.Text = dataForecastSetup.SimpleMAPeriodInMonth == null ? "" : dataForecastSetup.SimpleMAPeriodInMonth.ToString();
            centeredMAPeriodInMonthField.Text = dataForecastSetup.CenteredMAPeriodInMonth == null ? "" : dataForecastSetup.CenteredMAPeriodInMonth.ToString();
            forecastByCustomerCheckBox.Checked = dataForecastSetup.ForecastByCustomer == null ? false : (bool)dataForecastSetup.ForecastByCustomer;
            forecastByCustomerLocationCheckBox.Checked = dataForecastSetup.ForecastByCustomerLocation == null ? false : (bool)dataForecastSetup.ForecastByCustomerLocation;
            forecastByLocationCheckBox.Checked = dataForecastSetup.ForecastByLocation == null ? false : (bool)dataForecastSetup.ForecastByLocation;
            forecastByVariantCheckBox.Checked = dataForecastSetup.ForecastByVariant == null ? false : (bool)dataForecastSetup.ForecastByVariant;
            forecastByVendorCheckBox.Checked = dataForecastSetup.ForecastByVendor == null ? false : (bool)dataForecastSetup.ForecastByVendor;
            foreach (var item in Enum.GetValues(typeof(DateOption)))
            {
                overlapPeriodComboBox.Items.Add(item);
            }
            overlapPeriodComboBox.SelectedIndex = dataForecastSetup.OverlapPeriod == null ? -1 : (int)dataForecastSetup.OverlapPeriod;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.ForecastSetup.Remove(dataForecastSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codeField_TextChanged(object sender, EventArgs e)
        {
            dataForecastSetup.Code = codeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataForecastSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void alphaFactorField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(alphaFactorField.Text, out val))
            {
                dataForecastSetup.AlphaFactor = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void betaFactorField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(betaFactorField.Text, out val))
            {
                dataForecastSetup.BetaFactor = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void gammaFactorField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(gammaFactorField.Text, out val))
            {
                dataForecastSetup.GammaFactor = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void deltaFactorField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(deltaFactorField.Text, out val))
            {
                dataForecastSetup.DeltaFactor = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void trackingLimitField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(trackingLimitField.Text, out val))
            {
                dataForecastSetup.TrackingLimit = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void factorOptimizationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataForecastSetup.FactorOptimization = factorOptimizationCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void rankingField_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(rankingField.Text, out val))
            {
                dataForecastSetup.Ranking = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void simpleMAPeriodInMonthField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(simpleMAPeriodInMonthField.Text, out val))
            {
                dataForecastSetup.SimpleMAPeriodInMonth = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void centeredMAPeriodInMonthField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(centeredMAPeriodInMonthField.Text, out val))
            {
                dataForecastSetup.CenteredMAPeriodInMonth = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void forecastByCustomerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataForecastSetup.ForecastByCustomer = forecastByCustomerCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByCustomerLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataForecastSetup.ForecastByCustomerLocation = forecastByCustomerLocationCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataForecastSetup.ForecastByLocation = forecastByLocationCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByVariantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataForecastSetup.ForecastByVariant = forecastByVariantCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByVendorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataForecastSetup.ForecastByVendor = forecastByVendorCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void overlapPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataForecastSetup.OverlapPeriod = (DateOption)overlapPeriodComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void ForecastSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
