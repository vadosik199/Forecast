namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Forecast Setup")]
    public partial class Forecast_Setup
    {
        [Key]
        [Column("Primary Key")]
        [StringLength(10)]
        public string Primary_Key { get; set; }

        [Column("Default Forecast Period")]
        [StringLength(100)]
        public string Default_Forecast_Period { get; set; }

        [Column("Default Period Selection")]
        [StringLength(50)]
        public string Default_Period_Selection { get; set; }

        [Column("Forecast Value 1")]
        [StringLength(10)]
        public string Forecast_Value_1 { get; set; }

        [Column("Forecast Value 2")]
        [StringLength(10)]
        public string Forecast_Value_2 { get; set; }

        [Column("Forecast Value 3")]
        [StringLength(10)]
        public string Forecast_Value_3 { get; set; }

        [Column("Forecast Value 4")]
        [StringLength(10)]
        public string Forecast_Value_4 { get; set; }

        [Column("Forecast Value 5")]
        [StringLength(10)]
        public string Forecast_Value_5 { get; set; }

        [Column("Fiscal Year Starting Date", TypeName = "date")]
        public DateTime? Fiscal_Year_Starting_Date { get; set; }

        [Column("Fiscal Year Ending Date", TypeName = "date")]
        public DateTime? Fiscal_Year_Ending_Date { get; set; }

        [Column("No of Periods")]
        public int? No_of_Periods { get; set; }

        [Column("Period Length")]
        [StringLength(100)]
        public string Period_Length { get; set; }

        [Column("Default Period for Actual")]
        [StringLength(100)]
        public string Default_Period_for_Actual { get; set; }

        [Column("Overlap period")]
        [StringLength(100)]
        public string Overlap_period { get; set; }
    }
}
