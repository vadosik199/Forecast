using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Item Setup")]
    public class ItemSetup
    {
        [Key]
        [Column("Item No.")]
        [MaxLength(20)]
        public string ItemNo { get; set; }

        [Column("Item Description")]
        [MaxLength(50)]
        public string Description { get; set; }

        [Column("Base Unit of Measure")]
        [MaxLength(10)]
        public string UnitOfMeasure { get; set; }

        [Column("Purchase Unit of Measure")]
        [MaxLength(10)]
        public string PurchaseUnitOfMeasure { get; set; }

        [Column("Sales Unit of Measure")]
        [MaxLength(10)]
        public string SalesUnitOfMeasure { get; set; }

        [Column("Use history of Item")]
        [MaxLength(20)]
        public string UseHistoryOfItem { get; set; }

        [Column("Seasonal item")]
        public bool? SeasonalItem { get; set; }

        [Column("Safety stock")]
        public int? SafetyItem { get; set; }

        [Column("Customer buying calendar")]
        [MaxLength(20)]
        public string CustomerBuyingCalendar { get; set; }

        [Column("Vendor buying calendar")]
        [MaxLength(20)]
        public string VendorBuyingCalendar { get; set; }

        [Column("Lot aggregation Preference")]
        public DateOption? LotAggregationPreference { get; set; }

        [Column("Periods to be used for history")]
        public string PeriodsToBeUsedForHistory { get; set; }

        [Column("Forecasting Method")]
        [MaxLength(20)]
        public string ForecastingMethod { get; set; }

        [Column("Use POS data")]
        public bool? UsePOSData { get; set; }

        [Column("Item Classification")]
        public int? ItemClassification { get; set; }

        [Column("Variants exist")]
        public bool? VariantsExist { get; set; }

        [Column("Forecast by Variants")]
        public bool? ForecastByVariants { get; set; }

        [Column("Include Sales Return")]
        public bool? IncludeSalesReturn { get; set; }

        [Column("Alpha Factor")]
        public double? AlphaFactor { get; set; }

        [Column("Beta Factor")]
        public double? BetaFactor { get; set; }

        [Column("Gamma Factor")]
        public double? GammaFactor { get; set; }

        [Column("Delta Factor")]
        public double? DeltaFactor { get; set; }

        public double? P { get; set; }

        public double? D { get; set; }

        public double? Q { get; set; }

        [Column("Item Category")]
        [MaxLength(20)]
        public string ItemCategory { get; set; }

        [Column("Tracking Limit")]
        public double? TrackingLimit { get; set; }

        [Column("Factor Optimization")]
        public bool? FactorOptimization { get; set; }

        [Column("No of Period to Forecast")]
        public double? NoOfPeriodToForecast { get; set; }

        [Column("Forecast Period Aggregation Preference")]
        public DateOption? ForecastPeriodAggregationPreference { get; set; }

        [Column("MAD Tolerance")]
        public double? MADTolerance { get; set; }

        [Column("Seasonal Cycle Period")]
        public string SeasonalCyclePeriod { get; set; }

        [MaxLength(1)]
        public string Initialization { get; set; }

        [Column("Model Selection")]
        [MaxLength(10)]
        public string ModelSelection { get; set; }

        [Column("Optimization Level")]
        [MaxLength(10)]
        public string OptimizationLevel { get; set; }

        [Column("Forecast Unit of Measure")]
        [MaxLength(10)]
        public string ForecastUnitOfMeasure { get; set; }

        [Column("Forecast by Location")]
        public bool? ForecastByLocation { get; set; }

        [Column("Forecast By Customer")]
        public bool? ForecastByCustomer { get; set; }

        [Column("Simple M.A Period")]
        public int? SimpleMAPeriod { get; set; }

        [Column("Centered M.A Period")]
        public int? CenteredMAPeriod { get; set; }

        [Column("Seasonal Period Length")]
        public string SeasonalPeriodLength { get; set; }

        [Column("Safety Stock Qty")]
        public double? SafetyStockQty { get; set; }

        [Column("Safety Lead Time UOM")]
        public DateOption? SafetyLeadTimeUOM { get; set; }

        [Column("Safety Lead Time")]
        public DateOption? SafetyLeadTime { get; set; }

        [Column("Reorder Point")]
        public double? ReorderPoint { get; set; }

        [Column("Reorder Quantity")]
        public double? ReorderQuantity { get; set; }

        [Column("Minimum Inventory")]
        public double? MinimumInventory { get; set; }

        [Column("Maximum Inventory")]
        public double? MaximumInventory { get; set; }

        [Column("Forward/Backward Consumption UOM")]
        public DateOption? ForwardBackwardConsumptionUOM { get; set; }

        [Column("Forward Consumption")]
        public double? ForwardConsumption { get; set; }

        [Column("Backward  Consumption")]
        public double? BackwardConsumption { get; set; }

        [Column("BOM NO")]
        [MaxLength(30)]
        public string BOMNo { get; set; }

        [Column("Forecast Unit of Measure2")]
        [MaxLength(20)]
        public string ForecastUnitOfMeasure2 { get; set; }

        [Column("Lead Time UOM")]
        public DateOption? LeadTimeUOM { get; set; }

        [Column("Lead Time")]
        public double? LeadTime { get; set; }

        [Column("Overlap Period")]
        public DateOption? OverlapPeriod { get; set; }

        [Column("UPC Code")]
        [MaxLength(50)]
        public string UPCCode { get; set; }

        [Column("Customer Item code")]
        [MaxLength(30)]
        public string CustomerItemCode { get; set; }

        [Column("Vendor Item code")]
        [MaxLength(30)]
        public string VendorItemCode { get; set; }

        [Column("No of Variants")]
        public int? NoOfVariants { get; set; }
    }

    public enum DateOption
    {
        Day,
        Week,
        Month
    }
}
