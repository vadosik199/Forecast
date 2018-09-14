using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Vendor Setup")]
    public class VendorSetup
    {
        [Key]
        [Column("Vendor No")]
        [MaxLength(30)]
        public string VendorNo { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Blocked { get; set; }

        [Column("Item Code")]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Column("Item Description")]
        [MaxLength(100)]
        public string ItemDescription { get; set; }

        [Column("Lead time UOM")]
        public DateOption? LeadTimeUOM { get; set; }

        [Column("Lead time")]
        public decimal? LeadTime { get; set; }

        [Column("Vendor Location Code")]
        [MaxLength(30)]
        public string VendorLocationCode { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }
    }
}
