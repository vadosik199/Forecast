using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Customer Item Price")]
    public class CustomerItemPrice
    {
        [Key]
        [Column("Item No")]
        [MaxLength(30)]
        public string ItemNo { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("Customer Description")]
        [MaxLength(100)]
        public string CustomerDescription { get; set; }

        [Key]
        [Column("Customer Code")]
        [MaxLength(30)]
        public string CustomerCode { get; set; }

        [Column("Unit Price")]
        public int? UnitPrice { get; set; }

        [Column("Minimum Qty")]
        public double? MinimumQty { get; set; }

        [Key]
        [Column("Start Date")]
        public DateTime? StartDate { get; set; }

        [Column("End Date")]
        public DateTime? EndDate { get; set; }

        [Column("Unit of Measure")]
        public string UnitOfMeasure { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }
    }
}
