namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model Selection")]
    public partial class Model_Selection
    {
        [Key]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column("Ex Trend")]
        public bool? Ex_Trend { get; set; }

        [Column("Ex Seasonal")]
        public bool? Ex_Seasonal { get; set; }

        [Column("Ex Trend And Seasonal")]
        public bool? Ex_Trend_And_Seasonal { get; set; }
    }
}
