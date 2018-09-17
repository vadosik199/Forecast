using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("BOM Setup")]
    public class BOMSetup
    {
        [Key]
        [Column("BOM No")]
        [MaxLength(30)]
        public string BOMNo { get; set; }

        [Column("Line No")]
        public int? LineNo { get; set; }

        [Column("BOM Item No")]
        [MaxLength(50)]
        public string BOMItemNo { get; set; }

        [Column("BOM Variant Code")]
        public string BOMVariantCode { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("BOM Unit of Measure Code")]
        [MaxLength(10)]
        public string BOMUnitOfMeasureCode { get; set; }

        [Column("BOM Quantity")]
        public double? BOMQuantity { get; set; }

        [Column("Comp Item No")]
        public string CompItemNo { get; set; }

        [Column("Quantity per")]
        public double? QuantityPer { get; set; }

        [Column("Quantity Per base")]
        public double? QuantityPerBase { get; set; }

        [Column("Comp variant Code")]
        [MaxLength(30)]
        public string CompVariantCode { get; set; }
    }
}
