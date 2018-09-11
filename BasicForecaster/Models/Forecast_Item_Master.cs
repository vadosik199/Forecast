namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Forecast Item Master")]
    public partial class Forecast_Item_Master
    {
        public int Id { get; set; }

        [Column("Item No")]
        [StringLength(20)]
        public string Item_No { get; set; }

        [Column("Item Description")]
        [StringLength(50)]
        public string Item_Description { get; set; }

        [Column("Base Unit of Measure")]
        [StringLength(10)]
        public string Base_Unit_of_Measure { get; set; }

        [Column("Purchase Unit of Measure")]
        [StringLength(10)]
        public string Purchase_Unit_of_Measure { get; set; }

        [Column("Sales Unit of Measure")]
        [StringLength(10)]
        public string Sales_Unit_of_Measure { get; set; }

        [Column("Use history of Item")]
        [StringLength(20)]
        public string Use_history_of_Item { get; set; }

        [Column("Seasonal item")]
        public bool? Seasonal_item { get; set; }

        [Column("Safety stock")]
        public int? Safety_stock { get; set; }

        [Column("Customer buying calendar")]
        [StringLength(20)]
        public string Customer_buying_calendar { get; set; }

        [Column("Vendor buying calendar")]
        [StringLength(20)]
        public string Vendor_buying_calendar { get; set; }

        [Column("Period aggregation Preference")]
        [StringLength(30)]
        public string Period_aggregation_Preference { get; set; }

        [Column("Periods to be used for history")]
        [StringLength(100)]
        public string Periods_to_be_used_for_history { get; set; }

        [Column("Forecasting Method")]
        [StringLength(20)]
        public string Forecasting_Method { get; set; }

        [Column("Use POS data")]
        public bool? Use_POS_data { get; set; }

        [Column("Item Classification")]
        [StringLength(100)]
        public string Item_Classification { get; set; }

        [Column("Forecast by Variants")]
        public bool? Forecast_by_Variants { get; set; }

        [Column("Include Sales Return")]
        public bool? Include_Sales_Return { get; set; }

        [Column("Alpha Factor")]
        public decimal? Alpha_Factor { get; set; }

        [Column("Beta Factor")]
        public decimal? Beta_Factor { get; set; }

        [Column("Gamma Factor")]
        public decimal? Gamma_Factor { get; set; }

        [Column("Delta Factor")]
        public decimal? Delta_Factor { get; set; }

        [Column("Item Category")]
        [StringLength(20)]
        public string Item_Category { get; set; }

        [Column("Tracking Limit")]
        public decimal? Tracking_Limit { get; set; }

        [Column("Factor Optimization")]
        public bool? Factor_Optimization { get; set; }

        [Column("Forecast Horizon")]
        [StringLength(100)]
        public string Forecast_Horizon { get; set; }

        [Column("MAD Tolerence")]
        public decimal? MAD_Tolerence { get; set; }

        [Column("Seasonal Cycle Period")]
        [StringLength(100)]
        public string Seasonal_Cycle_Period { get; set; }

        [StringLength(1)]
        public string Initialization { get; set; }

        [Column("Model Selection")]
        [StringLength(10)]
        public string Model_Selection { get; set; }

        [Column("Forecast Unit of Measure")]
        [StringLength(10)]
        public string Forecast_Unit_of_Measure { get; set; }

        [Column("Forecast by Location")]
        public bool? Forecast_by_Location { get; set; }

        [Column("Simple M.A Period")]
        [StringLength(50)]
        public string Simple_M_A_Period { get; set; }

        [Column("Centered M.A Period")]
        [StringLength(50)]
        public string Centered_M_A_Period { get; set; }

        [Column("Variants exist")]
        public bool? Variants_exist { get; set; }

        [Column("Seasonal Period Length")]
        [StringLength(100)]
        public string Seasonal_Period_Length { get; set; }
    }
}
