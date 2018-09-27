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
    public partial class PlanningSetupCard : Form
    {
        private dbContext dataContext = null;
        private PlanningSetup dataPlanningSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public PlanningSetupCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.PlanningSetup.Load();
            dataPlanningSetup = new PlanningSetup();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
            foreach (var item in Enum.GetValues(typeof(DateOption)))
            {
                lotAccumulationPeriodComboBox.Items.Add(item);
                forwardBackwardConsumptionUOMComboBox.Items.Add(item);
                forecastPeriodAggregationPreferenceComboBox.Items.Add(item);
                periodsToBeUsedForHistoryUOMComboBox.Items.Add(item);
                safetyStockLeadTimeUOMComboBox.Items.Add(item);
            }
        }

        public PlanningSetupCard(int id, Form parentForm)
            :this(parentForm)
        {         
            dataPlanningSetup = dataContext.PlanningSetup.Where(u => u.ID == id).FirstOrDefault();
            idField.Text = dataPlanningSetup.ID.ToString();
            reorderPointField.Text = dataPlanningSetup.ReorderPoint == null ? "" : dataPlanningSetup.ReorderPoint.ToString();
            reorderQuantityField.Text = dataPlanningSetup.ReorderQuantity == null ? "" : dataPlanningSetup.ReorderQuantity.ToString();
            forwardConsumptionField.Text = dataPlanningSetup.ForwardConsumption == null ? "" : dataPlanningSetup.ForwardConsumption.ToString();
            backwardConsumptionField.Text = dataPlanningSetup.BaclwardConsumption == null ? "" : dataPlanningSetup.BaclwardConsumption.ToString();
            safetyStockQtyField.Text = dataPlanningSetup.SafetyStockQty == null ? "" : dataPlanningSetup.SafetyStockQty.ToString();
            safetyStockLeadTimeField.Text = dataPlanningSetup.SafetyStockLeadTime == null ? "" : dataPlanningSetup.SafetyStockLeadTime.ToString();
            noOfPeriodToForecastField.Text = dataPlanningSetup.NoOfPeriodToForecast == null ? "" : dataPlanningSetup.NoOfPeriodToForecast.ToString();
            periodsToBeUsedForHistoryField.Text = dataPlanningSetup.PeriodsToBeUsedForHistory == null ? "" : dataPlanningSetup.PeriodsToBeUsedForHistory.ToString();
            deportRequirementPlanningCheckBox.Checked = dataPlanningSetup.DeportRequirementPlanning == null ? false : (bool)dataPlanningSetup.DeportRequirementPlanning;
            lotAccumulationPeriodComboBox.SelectedIndex = dataPlanningSetup.LotAccumulationPeriod == null ? -1 : (int)dataPlanningSetup.LotAccumulationPeriod;
            forwardBackwardConsumptionUOMComboBox.SelectedIndex = dataPlanningSetup.ForwardBackwardConsumptionUOM == null ? -1 : (int)dataPlanningSetup.ForwardBackwardConsumptionUOM;
            forecastPeriodAggregationPreferenceComboBox.SelectedIndex = dataPlanningSetup.ForecastPeriodAggregationPreference == null ? -1 : (int)dataPlanningSetup.ForecastPeriodAggregationPreference;
            periodsToBeUsedForHistoryUOMComboBox.SelectedIndex = dataPlanningSetup.PeriodsToBeUsedForHistoryUOM == null ? -1 : (int)dataPlanningSetup.PeriodsToBeUsedForHistoryUOM;
            safetyStockLeadTimeUOMComboBox.SelectedIndex = dataPlanningSetup.SafetyStockLeadTimeUOM == null ? -1 : (int)dataPlanningSetup.SafetyStockLeadTimeUOM;

            if (!IsNew)
            {
                idField.Enabled = false;
                SaveButton.Visible = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.PlanningSetup.Remove(dataPlanningSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idField_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(idField.Text, out id))
            {
                dataPlanningSetup.ID = id;
            }
            dataContext.SaveData(errorHandler);
        }

        private void reorderPointField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(reorderPointField.Text, out val))
            {
                dataPlanningSetup.ReorderPoint = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void reorderQuantityField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(reorderQuantityField.Text, out val))
            {
                dataPlanningSetup.ReorderQuantity = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void forwardConsumptionField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(forwardConsumptionField.Text, out val))
            {
                dataPlanningSetup.ForwardConsumption = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void backwardConsumptionField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(backwardConsumptionField.Text, out val))
            {
                dataPlanningSetup.BaclwardConsumption = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void safetyStockQtyField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(safetyStockQtyField.Text, out val))
            {
                dataPlanningSetup.SafetyStockQty = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void safetyStockLeadTimeField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(safetyStockLeadTimeField.Text, out val))
            {
                dataPlanningSetup.SafetyStockLeadTime = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void noOfPeriodToForecastField_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(noOfPeriodToForecastField.Text, out val))
            {
                dataPlanningSetup.NoOfPeriodToForecast = val;
            }
            dataContext.SaveData(errorHandler);
        }

        private void periodsToBeUsedForHistoryField_TextChanged(object sender, EventArgs e)
        {
            int period;
            if (int.TryParse(periodsToBeUsedForHistoryField.Text, out period))
            {
                dataPlanningSetup.PeriodsToBeUsedForHistory = period;
            }
            dataContext.SaveData(errorHandler);
        }

        private void deportRequirementPlanningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataPlanningSetup.DeportRequirementPlanning = deportRequirementPlanningCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void lotAccumulationPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPlanningSetup.LotAccumulationPeriod = (DateOption)lotAccumulationPeriodComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void forecastPeriodAggregationPreferenceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPlanningSetup.ForecastPeriodAggregationPreference = (DateOption)forecastPeriodAggregationPreferenceComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void forwardBackwardConsumptionUOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPlanningSetup.ForwardBackwardConsumptionUOM = (DateOption)forwardBackwardConsumptionUOMComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void safetyStockLeadTimeUOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPlanningSetup.SafetyStockLeadTimeUOM = (DateOption)safetyStockLeadTimeUOMComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void periodsToBeUsedForHistoryUOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPlanningSetup.PeriodsToBeUsedForHistoryUOM = (DateOption)periodsToBeUsedForHistoryUOMComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void PlanningSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            PlanningSetupCard planningSetup = new PlanningSetupCard(parentForm, true);
            planningSetup.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(idField.Text))
                    {
                        throw new Exception("Field 'ID' can`t be empty!");
                    }
                    int id = int.Parse(idField.Text);
                    if (context.PlanningSetup.Where(vs => vs.ID == id).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'ID' = {idField.Text} already exist!");
                    }
                    if (int.TryParse(idField.Text, out id))
                    {
                        dataPlanningSetup.ID = id;
                    }
                    double val;
                    if (double.TryParse(reorderPointField.Text, out val))
                    {
                        dataPlanningSetup.ReorderPoint = val;
                    }
                    if (double.TryParse(reorderQuantityField.Text, out val))
                    {
                        dataPlanningSetup.ReorderQuantity = val;
                    }
                    if (double.TryParse(forwardConsumptionField.Text, out val))
                    {
                        dataPlanningSetup.ForwardConsumption = val;
                    }
                    if (double.TryParse(backwardConsumptionField.Text, out val))
                    {
                        dataPlanningSetup.BaclwardConsumption = val;
                    }
                    if (double.TryParse(safetyStockQtyField.Text, out val))
                    {
                        dataPlanningSetup.SafetyStockQty = val;
                    }
                    if (double.TryParse(safetyStockLeadTimeField.Text, out val))
                    {
                        dataPlanningSetup.SafetyStockLeadTime = val;
                    }
                    if (double.TryParse(noOfPeriodToForecastField.Text, out val))
                    {
                        dataPlanningSetup.NoOfPeriodToForecast = val;
                    }
                    int period;
                    if (int.TryParse(periodsToBeUsedForHistoryField.Text, out period))
                    {
                        dataPlanningSetup.PeriodsToBeUsedForHistory = period;
                    }
                    dataPlanningSetup.DeportRequirementPlanning = deportRequirementPlanningCheckBox.Checked;
                    if (lotAccumulationPeriodComboBox.SelectedIndex == -1)
                    {
                        dataPlanningSetup.LotAccumulationPeriod = null;
                    }
                    else
                    {
                        dataPlanningSetup.LotAccumulationPeriod = (DateOption)lotAccumulationPeriodComboBox.SelectedIndex;
                    }
                    if (forecastPeriodAggregationPreferenceComboBox.SelectedIndex == -1)
                    {
                        dataPlanningSetup.ForecastPeriodAggregationPreference = null;
                    }
                    else
                    {
                        dataPlanningSetup.ForecastPeriodAggregationPreference = (DateOption)forecastPeriodAggregationPreferenceComboBox.SelectedIndex;
                    }
                    if (forwardBackwardConsumptionUOMComboBox.SelectedIndex == -1)
                    {
                        dataPlanningSetup.ForwardBackwardConsumptionUOM = null;
                    }
                    else
                    {
                        dataPlanningSetup.ForwardBackwardConsumptionUOM = (DateOption)forwardBackwardConsumptionUOMComboBox.SelectedIndex;
                    }
                    if (safetyStockLeadTimeUOMComboBox.SelectedIndex == -1)
                    {
                        dataPlanningSetup.SafetyStockLeadTimeUOM = null;
                    }
                    else
                    {
                        dataPlanningSetup.SafetyStockLeadTimeUOM = (DateOption)safetyStockLeadTimeUOMComboBox.SelectedIndex;
                    }
                    if (periodsToBeUsedForHistoryUOMComboBox.SelectedIndex == -1)
                    {
                        dataPlanningSetup.PeriodsToBeUsedForHistoryUOM = null;
                    }
                    else
                    {
                        dataPlanningSetup.PeriodsToBeUsedForHistoryUOM = (DateOption)periodsToBeUsedForHistoryUOMComboBox.SelectedIndex;
                    }
                    context.PlanningSetup.Add(dataPlanningSetup);
                    context.SaveData(errorHandler);
                    PlanningSetupCard newPlanningSetupCard = new PlanningSetupCard(dataPlanningSetup.ID, parentForm);
                    newPlanningSetupCard.Show();
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
