using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Forecast Setup2")]
    public class ForecastSetup
    {
        [Key]
        [MaxLength(20)]
        public string Code { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [Column("Alpha Factor")]
        public double? AlphaFactor { get; set; }

        [Column("Beta Factor")]
        public double? BetaFactor { get; set; }

        [Column("Gamma Factor")]
        public double? GammaFactor { get; set; }

        [Column("Delta Factor")]
        public double? DeltaFactor { get; set; }

        [Column("Tracking Limit")]
        public double? TrackingLimit { get; set; }

        [Column("Factor Optimization")]
        public bool? FactorOptimization { get; set; }

        public int? Ranking { get; set; }

        [Column("Simple M.A Period in Months")]
        public double? SimpleMAPeriodInMonth { get; set; }

        [Column("Centered M.A Period in Months")]
        public double? CenteredMAPeriodInMonth { get; set; }

        [Column("Forecast by Customer")]
        public bool? ForecastByCustomer { get; set; }

        [Column("Forecast by Customer Location")]
        public bool? ForecastByCustomerLocation { get; set; }

        [Column("Forecast by Location")]
        public bool? ForecastByLocation { get; set; }

        [Column("Forecast by Variant")]
        public bool? ForecastByVariant { get; set; }

        [Column("Forecast by Vendor")]
        public bool? ForecastByVendor { get; set; }

        [Column("Overlap Period")]
        public DateOption? OverlapPeriod { get; set; }
    }
}
