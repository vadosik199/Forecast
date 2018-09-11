namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exclude From History")]
    public partial class Exclude_From_History
    {
        [Key]
        [Column("Item No")]
        [StringLength(20)]
        public string Item_No { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column("Line No")]
        public int? Line_No { get; set; }

        [Column("From Date", TypeName = "date")]
        public DateTime? From_Date { get; set; }

        [Column("To Date", TypeName = "date")]
        public DateTime? To_Date { get; set; }
    }
}
