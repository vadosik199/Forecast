namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Forecast Methods")]
    public partial class Forecast_Method
    {
        [Key]
        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column("Alpha Factor")]
        public decimal? Alpha_Factor { get; set; }

        [Column("Beta Factor")]
        public decimal? Beta_Factor { get; set; }

        [Column("Gamma Factor")]
        public decimal? Gamma_Factor { get; set; }

        [Column("Delta Factor")]
        public decimal? Delta_Factor { get; set; }

        [Column("Tracking Limit")]
        public decimal? Tracking_Limit { get; set; }

        [Column("Factor Optimizaton")]
        public bool? Factor_Optimizaton { get; set; }

        [Column("Forecast Horizon")]
        [StringLength(100)]
        public string Forecast_Horizon { get; set; }

        [Column("MAD Tolerence")]
        public decimal? MAD_Tolerence { get; set; }

        public int? Ranking { get; set; }

        [Column("Simple M.A Period")]
        [StringLength(50)]
        public string Simple_M_A_Period { get; set; }

        [Column("Centered M.A Period")]
        [StringLength(50)]
        public string Centered_M_A_Period { get; set; }
    }
}
