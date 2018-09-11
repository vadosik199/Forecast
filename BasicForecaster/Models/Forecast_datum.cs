namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Forecast Data")]
    public partial class Forecast_datum
    {
        public int Id { get; set; }

        [Column("Item No")]
        [StringLength(20)]
        public string Item_No { get; set; }

        [Column("Entry No")]
        public int? Entry_No { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column("Actual Sales Qty")]
        public decimal? Actual_Sales_Qty { get; set; }

        [Column("Forecast UOM")]
        [StringLength(10)]
        public string Forecast_UOM { get; set; }

        [Column("Forecast Value 1")]
        public decimal? Forecast_Value_1 { get; set; }

        [Column("Forecast Value 2")]
        public decimal? Forecast_Value_2 { get; set; }

        [Column("Forecast Value 3")]
        public decimal? Forecast_Value_3 { get; set; }

        [Column("Forecast Value 4")]
        public decimal? Forecast_Value_4 { get; set; }

        [Column("Forecast Value 5")]
        public decimal? Forecast_Value_5 { get; set; }

        [Column("MOD/Error")]
        public decimal? MOD_Error { get; set; }

        [Column("Best Value")]
        public decimal? Best_Value { get; set; }

        [StringLength(10)]
        public string Location { get; set; }

        [Column("Forecast Horizon")]
        [StringLength(100)]
        public string Forecast_Horizon { get; set; }

        [Column("Forecast From Date", TypeName = "date")]
        public DateTime? Forecast_From_Date { get; set; }

        [Column("Forecast To Date", TypeName = "date")]
        public DateTime? Forecast_To_Date { get; set; }

        [Column("Seasonality Exist")]
        public bool? Seasonality_Exist { get; set; }

        [Column("Forecast Period")]
        [StringLength(100)]
        public string Forecast_Period { get; set; }

        [Column("Item Category")]
        [StringLength(10)]
        public string Item_Category { get; set; }

        [Column("Best Method")]
        [StringLength(10)]
        public string Best_Method { get; set; }

        [Column("Date Last Run", TypeName = "date")]
        public DateTime? Date_Last_Run { get; set; }
    }
}
