using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Planning Setup")]
    public class PlanningSetup
    {
        [Key]
        public int ID { get; set; }

        [Column("Reorder Point")]
        public double? ReorderPoint { get; set; }

        [Column("Reorder Quantity")]
        public double? ReorderQuantity { get; set; }

        [Column("Lot Accumulation Period")]
        public DateOption? LotAccumulationPeriod { get; set; }

        [Column("Forecast Period Aggregation Preference")]
        public DateOption? ForecastPeriodAggregationPreference { get; set; }

        [Column("Forward Backward Consumption UOM")]
        public DateOption? ForwardBackwardConsumptionUOM { get; set; }

        [Column("Forward Consumption")]
        public double? ForwardConsumption { get; set; }

        [Column("Backward  Consumption")]
        public double? BaclwardConsumption { get; set; }

        [Column("Safety Stock Qty")]
        public double? SafetyStockQty { get; set; }

        [Column("Safety Stock Lead time  UOM")]
        public DateOption? SafetyStockLeadTimeUOM { get; set; }

        [Column("Safety Stock Lead time")]
        public double? SafetyStockLeadTime { get; set; }

        [Column("No of Period to Forecast")]
        public double? NoOfPeriodToForecast { get; set; }

        [Column("Periods to be used for history UOM")]
        public DateOption? PeriodsToBeUsedForHistoryUOM { get; set; }

        [Column("Periods to be used for history")]
        public int? PeriodsToBeUsedForHistory { get; set; }

        [Column("Deport Requirement Planning")]
        public bool? DeportRequirementPlanning { get; set; }
    }
}
