namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Optimization Level")]
    public partial class Optimization_Level
    {
        [Key]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column("From MAD")]
        public int? From_MAD { get; set; }

        [Column("To MAD")]
        public int? To_MAD { get; set; }
    }
}
