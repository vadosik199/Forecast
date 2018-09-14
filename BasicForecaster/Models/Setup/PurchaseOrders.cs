using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Purchase Orders")]
    public class PurchaseOrders
    {
        [Column("Purchase Order No")]
        [MaxLength(30)]
        public string PurchaseOrderNo { get; set; }

        [Column("Vendor Code")]
        [MaxLength(30)]
        public string VendorNo { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("Item Code")]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Column("Item Description")]
        [MaxLength(100)]
        public string ItemDescription { get; set; }

        [Column("Purchase Price")]
        public int? PurchasePrice { get; set; }

        public double? Quantity { get; set; }

        [Column("Unit Of Measure")]
        [MaxLength(30)]
        public string UnitOfMeasure { get; set; }

        [Column("Expected Receipt  Date")]
        public DateTime? ExpectedReceiptDate { get; set; }

        [Column("Location Code")]
        [MaxLength(30)]
        public string LocationCode { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }

        [Column("Vendor Location Code")]
        [MaxLength(30)]
        public string VendorLocationCode { get; set; }

        [Column("Order Date")]
        public DateTime? OrderDate { get; set; }
    }
}
