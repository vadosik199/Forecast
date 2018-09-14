using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Assembly Orders Production Orders")]
    public class AssemblyOrdersProductionOrders
    {
        [Key]
        [Column("Production Order No")]
        [MaxLength(30)]
        public string ProductionOrderNo { get; set; }

        [Column("Item Code")]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Column("Item Description")]
        [MaxLength(100)]
        public string ItemDescription { get; set; }

        [Column("Quantity to Make")]
        public double? QuantityToMake { get; set; }

        [Column("Unit Of Measure")]
        [MaxLength(30)]
        public string UnitOfMeasure { get; set; }

        [Column("Expected completion  Date")]
        public DateTime? ExpectedCompletionDate { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }

        [Column("Location Code")]
        [MaxLength(30)]
        public string LocationCode { get; set; }

        [Column("Order Date")]
        public DateTime? OrderDate { get; set; }
    }
}
