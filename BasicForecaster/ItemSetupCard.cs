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
    public partial class ItemSetupCard : Form
    {
        private dbContext dataContext = null;
        private ItemSetup dataItemSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public ItemSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public ItemSetupCard(string itemNo, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.ItemSetup.Load();
            dataItemSetup = dataContext.ItemSetup.Where(u => u.ItemNo.Equals(itemNo)).FirstOrDefault();
            itemNoField.Text = dataItemSetup.ItemNo;
            descriptionField.Text = dataItemSetup.Description;
            unitOfMeasureField.Text = dataItemSetup.UnitOfMeasure;
            purchaseUnitOfMeasureField.Text = dataItemSetup.PurchaseUnitOfMeasure;
            salesUnitOfMeasureField.Text = dataItemSetup.SalesUnitOfMeasure;
            useHistoryOfItemField.Text = dataItemSetup.UseHistoryOfItem;
            seasonalItemCheckBox.Checked = dataItemSetup.SeasonalItem == null ? false : (bool)dataItemSetup.SeasonalItem;
            safetyItemField.Text = dataItemSetup.SafetyItem == null ? "" : dataItemSetup.SafetyItem.ToString();
            customerBuyingCalendarField.Text = dataItemSetup.CustomerBuyingCalendar;
            vendorBuyingCalendarField.Text = dataItemSetup.VendorBuyingCalendar;
            periodsToBeUsedForHistoryField.Text = dataItemSetup.PeriodsToBeUsedForHistory;
            forecastingMethodField.Text = dataItemSetup.ForecastingMethod;
            usePOSDataCheckBox.Checked = dataItemSetup.UsePOSData == null ? false : (bool)dataItemSetup.UsePOSData;
            itemClassificationField.Text = dataItemSetup.ItemClassification == null ? "" : dataItemSetup.ItemClassification.ToString();
            variantsExistCheckBox.Checked = dataItemSetup.VariantsExist == null ? false : (bool)dataItemSetup.VariantsExist;
            forecastByVariantsCheckBox.Checked = dataItemSetup.ForecastByVariants == null ? false : (bool)dataItemSetup.ForecastByVariants;
            includeSalesReturnCheckBox.Checked = dataItemSetup.IncludeSalesReturn == null ? false : (bool)dataItemSetup.IncludeSalesReturn;
            alphaFactorField.Text = dataItemSetup.AlphaFactor == null ? "" : dataItemSetup.AlphaFactor.ToString();
            gammaFactorField.Text = dataItemSetup.GammaFactor == null ? "" : dataItemSetup.GammaFactor.ToString();
            betaFactorField.Text = dataItemSetup.BetaFactor == null ? "" : dataItemSetup.BetaFactor.ToString();
            deltaFactorField.Text = dataItemSetup.DeltaFactor == null ? "" : dataItemSetup.DeltaFactor.ToString();
            pField.Text = dataItemSetup.P == null ? "" : dataItemSetup.P.ToString();
            dField.Text = dataItemSetup.D == null ? "" : dataItemSetup.D.ToString();
            qField.Text = dataItemSetup.Q == null ? "" : dataItemSetup.Q.ToString();
            itemCategoryField.Text = dataItemSetup.ItemCategory;
            trackingLimitField.Text = dataItemSetup.TrackingLimit == null ? "" : dataItemSetup.TrackingLimit.ToString();
            factorOptimisarionCheckBox.Checked = dataItemSetup.FactorOptimization == null ? false : (bool)dataItemSetup.FactorOptimization;
            noOfPeriodToForecastField.Text = dataItemSetup.NoOfPeriodToForecast == null ? "" : dataItemSetup.NoOfPeriodToForecast.ToString();
            madToleranceField.Text = dataItemSetup.MADTolerance == null ? "" : dataItemSetup.MADTolerance.ToString();
            seasonalCyclePeriodField.Text = dataItemSetup.SeasonalCyclePeriod;
            initializationField.Text = dataItemSetup.Initialization;
            modelSelectionField.Text = dataItemSetup.ModelSelection;
            optimizationLevelField.Text = dataItemSetup.OptimizationLevel;
            forecastUnitOfMeasureField.Text = dataItemSetup.ForecastUnitOfMeasure;
            forecastByLocationCheckBox.Checked = dataItemSetup.ForecastByLocation == null ? false : (bool)dataItemSetup.ForecastByLocation;
            forecastByCustomerCheckBox.Checked = dataItemSetup.ForecastByCustomer == null ? false : (bool)dataItemSetup.ForecastByCustomer;
            simpleMAPeridoField.Text = dataItemSetup.SimpleMAPeriod == null ? "" : dataItemSetup.SimpleMAPeriod.ToString();
            centeredMAPeriodField.Text = dataItemSetup.CenteredMAPeriod == null ? "" : dataItemSetup.CenteredMAPeriod.ToString();
            seasonalPeriodLengthField.Text = dataItemSetup.SeasonalPeriodLength;
            safetyStockQtyField.Text = dataItemSetup.SafetyStockQty == null ? "" : dataItemSetup.SafetyStockQty.ToString();
            reorderPointField.Text = dataItemSetup.ReorderPoint == null ? "" : dataItemSetup.ReorderPoint.ToString();
            reorderQuantityField.Text = dataItemSetup.ReorderQuantity == null ? "" : dataItemSetup.ReorderQuantity.ToString();
            minimumInventoryField.Text = dataItemSetup.MinimumInventory == null ? "" : dataItemSetup.MinimumInventory.ToString();
            maximumInventoryField.Text = dataItemSetup.MaximumInventory == null ? "" : dataItemSetup.MaximumInventory.ToString();
            forwardConsumptionField.Text = dataItemSetup.ForwardConsumption == null ? "" : dataItemSetup.ForwardConsumption.ToString();
            backwardConsumptionField.Text = dataItemSetup.BackwardConsumption == null ? "" : dataItemSetup.BackwardConsumption.ToString();
            bomNoField.Text = dataItemSetup.BOMNo;
            leadTimeField.Text = dataItemSetup.LeadTime == null ? "" : dataItemSetup.LeadTime.ToString();
            upcCodeField.Text = dataItemSetup.UPCCode;
            customerItemCodeField.Text = dataItemSetup.CustomerItemCode;
            vendorItemCodeField.Text = dataItemSetup.VendorItemCode;
            noOfVariantsField.Text = dataItemSetup.NoOfVariants == null ? "" : dataItemSetup.NoOfVariants.ToString();
            foreach (var item in Enum.GetValues(typeof(DateOption)))
            {
                lotAggregationPreferenceComboBox.Items.Add(item);
                forecastPeriodAggregationPreferenceComboBox.Items.Add(item);
                safetyLeadTimeField.Items.Add(item);
                safetyLeadTimeUOMField.Items.Add(item);
                forwardBackwardConsumptionUONField.Items.Add(item);
                leadTimeUOMField.Items.Add(item);
                overlapPeriodCheckBox.Items.Add(item);
            }
            lotAggregationPreferenceComboBox.SelectedIndex = dataItemSetup.LotAggregationPreference == null ? -1 : (int)dataItemSetup.LotAggregationPreference;
            forecastPeriodAggregationPreferenceComboBox.SelectedIndex = dataItemSetup.ForecastPeriodAggregationPreference == null ? -1 : (int)dataItemSetup.ForecastPeriodAggregationPreference;
            safetyLeadTimeUOMField.SelectedIndex = dataItemSetup.SafetyLeadTimeUOM == null ? -1 : (int)dataItemSetup.SafetyLeadTimeUOM;
            safetyLeadTimeField.SelectedIndex = dataItemSetup.SafetyLeadTime == null ? -1 : (int)dataItemSetup.SafetyLeadTime;
            forwardBackwardConsumptionUONField.SelectedIndex = dataItemSetup.ForwardBackwardConsumptionUOM == null ? -1 : (int)dataItemSetup.ForwardBackwardConsumptionUOM;
            leadTimeUOMField.SelectedIndex = dataItemSetup.LeadTimeUOM == null ? -1 : (int)dataItemSetup.LeadTimeUOM;
            overlapPeriodCheckBox.SelectedIndex = dataItemSetup.OverlapPeriod == null ? -1 : (int)dataItemSetup.OverlapPeriod;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.ItemSetup.Remove(dataItemSetup);
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
            dataItemSetup.ItemNo = itemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.UnitOfMeasure = unitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void purchaseUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.PurchaseUnitOfMeasure = purchaseUnitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void salesUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.SalesUnitOfMeasure = salesUnitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void useHistoryOfItemField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.UseHistoryOfItem = useHistoryOfItemField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void seasonalItemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.SeasonalItem = seasonalItemCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void safetyItemField_TextChanged(object sender, EventArgs e)
        {
            int safetyItem;
            if (int.TryParse(safetyItemField.Text, out safetyItem))
            {
                dataItemSetup.SafetyItem = safetyItem;
            }
            dataContext.SaveData(errorHandler);
        }

        private void customerBuyingCalendarField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.CustomerBuyingCalendar = customerBuyingCalendarField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void vendorBuyingCalendarField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.VendorBuyingCalendar = vendorBuyingCalendarField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void lotAggregationPreferenceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.LotAggregationPreference = (DateOption)lotAggregationPreferenceComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void periodsToBeUsedForHistoryField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.PeriodsToBeUsedForHistory = periodsToBeUsedForHistoryField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void forecastingMethodField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForecastingMethod = forecastingMethodField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void usePOSDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.UsePOSData = usePOSDataCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void itemClassificationField_TextChanged(object sender, EventArgs e)
        {
            int itemClassification;
            if (int.TryParse(itemClassificationField.Text, out itemClassification))
            {
                dataItemSetup.ItemClassification = itemClassification;
            }
            dataContext.SaveData(errorHandler);
        }

        private void variantsExistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.VariantsExist = variantsExistCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByVariantsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForecastByVariants = forecastByVariantsCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void includeSalesReturnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.IncludeSalesReturn = includeSalesReturnCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void alphaFactorField_TextChanged(object sender, EventArgs e)
        {
            double alpha;
            if (double.TryParse(alphaFactorField.Text, out alpha))
            {
                dataItemSetup.AlphaFactor = alpha;
            }
            dataContext.SaveData(errorHandler);
        }

        private void betaFactorField_TextChanged(object sender, EventArgs e)
        {
            double beta;
            if (double.TryParse(betaFactorField.Text, out beta))
            {
                dataItemSetup.BetaFactor = beta;
            }
            dataContext.SaveData(errorHandler);
        }

        private void gammaFactorField_TextChanged(object sender, EventArgs e)
        {
            double gamma;
            if (double.TryParse(gammaFactorField.Text, out gamma))
            {
                dataItemSetup.GammaFactor = gamma;
            }
            dataContext.SaveData(errorHandler);
        }

        private void deltaFactorField_TextChanged(object sender, EventArgs e)
        {
            double delta;
            if (double.TryParse(deltaFactorField.Text, out delta))
            {
                dataItemSetup.DeltaFactor = delta;
            }
            dataContext.SaveData(errorHandler);
        }

        private void pField_TextChanged(object sender, EventArgs e)
        {
            double p;
            if (double.TryParse(pField.Text, out p))
            {
                dataItemSetup.P = p;
            }
            dataContext.SaveData(errorHandler);
        }

        private void dField_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(dField.Text, out d))
            {
                dataItemSetup.D = d;
            }
            dataContext.SaveData(errorHandler);
        }

        private void qField_TextChanged(object sender, EventArgs e)
        {
            double q;
            if (double.TryParse(qField.Text, out q))
            {
                dataItemSetup.Q = q;
            }
            dataContext.SaveData(errorHandler);
        }

        private void itemCategoryField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.ItemCategory = itemCategoryField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void trackingLimitField_TextChanged(object sender, EventArgs e)
        {
            double limit;
            if (double.TryParse(trackingLimitField.Text, out limit))
            {
                dataItemSetup.TrackingLimit = limit;
            }
            dataContext.SaveData(errorHandler);
        }

        private void factorOptimisarionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.FactorOptimization = factorOptimisarionCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void noOfPeriodToForecastField_TextChanged(object sender, EventArgs e)
        {
            double no;
            if (double.TryParse(noOfPeriodToForecastField.Text, out no))
            {
                dataItemSetup.NoOfPeriodToForecast = no;
            }
            dataContext.SaveData(errorHandler);
        }

        private void forecastPeriodAggregationPreferenceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForecastPeriodAggregationPreference = (DateOption)forecastPeriodAggregationPreferenceComboBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void madToleranceField_TextChanged(object sender, EventArgs e)
        {
            double mad;
            if (double.TryParse(madToleranceField.Text, out mad))
            {
                dataItemSetup.MADTolerance = mad;
            }
            dataContext.SaveData(errorHandler);
        }

        private void seasonalCyclePeriodField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.SeasonalCyclePeriod = seasonalCyclePeriodField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void initializationField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.Initialization = initializationField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void modelSelectionField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.ModelSelection = modelSelectionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void optimizationLevelField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.OptimizationLevel = optimizationLevelField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void forecastUnitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForecastUnitOfMeasure = forecastUnitOfMeasureField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForecastByLocation = forecastByLocationCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void forecastByCustomerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForecastByCustomer = forecastByCustomerCheckBox.Checked;
            dataContext.SaveData(errorHandler);
        }

        private void simpleMAPeridoField_TextChanged(object sender, EventArgs e)
        {
            int period;
            if (int.TryParse(simpleMAPeridoField.Text, out period))
            {
                dataItemSetup.SimpleMAPeriod = period;
            }
            dataContext.SaveData(errorHandler);
        }

        private void centeredMAPeriodField_TextChanged(object sender, EventArgs e)
        {
            int period;
            if (int.TryParse(centeredMAPeriodField.Text, out period))
            {
                dataItemSetup.CenteredMAPeriod = period;
            }
            dataContext.SaveData(errorHandler);
        }

        private void seasonalPeriodLengthField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.SeasonalPeriodLength = seasonalPeriodLengthField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void safetyStockQtyField_TextChanged(object sender, EventArgs e)
        {
            double qty;
            if (double.TryParse(safetyStockQtyField.Text, out qty))
            {
                dataItemSetup.SafetyStockQty = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void safetyLeadTimeUOMField_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.SafetyLeadTimeUOM = (DateOption)safetyLeadTimeUOMField.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void safetyLeadTimeField_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.SafetyLeadTime = (DateOption)safetyLeadTimeUOMField.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void reorderPointField_TextChanged(object sender, EventArgs e)
        {
            double point;
            if (double.TryParse(reorderPointField.Text, out point))
            {
                dataItemSetup.ReorderPoint = point;
            }
            dataContext.SaveData(errorHandler);
        }

        private void reorderQuantityField_TextChanged(object sender, EventArgs e)
        {
            double qty;
            if (double.TryParse(reorderQuantityField.Text, out qty))
            {
                dataItemSetup.ReorderQuantity = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void minimumInventoryField_TextChanged(object sender, EventArgs e)
        {
            double qty;
            if (double.TryParse(minimumInventoryField.Text, out qty))
            {
                dataItemSetup.MinimumInventory = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void maximumInventoryField_TextChanged(object sender, EventArgs e)
        {
            double qty;
            if (double.TryParse(maximumInventoryField.Text, out qty))
            {
                dataItemSetup.MaximumInventory = qty;
            }
            dataContext.SaveData(errorHandler);
        }

        private void forwardBackwardConsumptionUONField_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.ForwardBackwardConsumptionUOM = (DateOption)forwardBackwardConsumptionUONField.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void forwardConsumptionField_TextChanged(object sender, EventArgs e)
        {
            double consumption;
            if (double.TryParse(forwardConsumptionField.Text, out consumption))
            {
                dataItemSetup.ForwardConsumption = consumption;
            }
            dataContext.SaveData(errorHandler);
        }

        private void backwardConsumptionField_TextChanged(object sender, EventArgs e)
        {
            double consumption;
            if (double.TryParse(backwardConsumptionField.Text, out consumption))
            {
                dataItemSetup.BackwardConsumption = consumption;
            }
            dataContext.SaveData(errorHandler);
        }

        private void bomNoField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.BOMNo = bomNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void leadTimeUOMField_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.LeadTimeUOM = (DateOption)leadTimeUOMField.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void leadTimeField_TextChanged(object sender, EventArgs e)
        {
            double time;
            if (double.TryParse(leadTimeField.Text, out time))
            {
                dataItemSetup.LeadTime = time;
            }
            dataContext.SaveData(errorHandler);
        }

        private void overlapPeriodCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataItemSetup.OverlapPeriod = (DateOption)overlapPeriodCheckBox.SelectedIndex;
            dataContext.SaveData(errorHandler);
        }

        private void upcCodeField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.UPCCode = upcCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void customerItemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.CustomerItemCode = customerItemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void vendorItemCodeField_TextChanged(object sender, EventArgs e)
        {
            dataItemSetup.VendorItemCode = vendorItemCodeField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void noOfVariantsField_TextChanged(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(noOfVariantsField.Text, out no))
            {
                dataItemSetup.NoOfVariants = no;
            }
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void ItemSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
