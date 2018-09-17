using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Variant Setup")]
    public class VariantSetup
    {
        [Key]
        [Column(name: "Item Code", Order = 1)]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Key]
        [Column(name: "Variant Code", Order = 2)]
        [MaxLength(30)]
        public string VariantCode { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("Item Description")]
        public string ItemDescription { get; set; }

        [Column("Unit of Measure Code")]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        [Column("Location code")]
        [MaxLength(30)]
        public string LocationCode { get; set; }

        [Column("Customer Variant Code")]
        [MaxLength(30)]
        public string CustomerVariantCode { get; set; }

        [Column("Vendor Variant Code")]
        [MaxLength(30)]
        public string VendorVariantCode { get; set; }
    }
}
