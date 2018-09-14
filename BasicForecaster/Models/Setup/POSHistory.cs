using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("POS History")]
    public class POSHistory
    {
        [Key]
        [Column("Entry No")]
        public double EntryNo { get; set; }

        [Column("Store No")]
        [MaxLength(30)]
        public string StoreNo { get; set; }

        [Column("Store Name")]
        [MaxLength(100)]
        public string StoreName { get; set; }

        [MaxLength(100)]
        public string Retailor { get; set; }

        [MaxLength(50)]
        public string Address1 { get; set; }

        [MaxLength(50)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        public string Zip { get; set; }

        [MaxLength(50)]
        public string UPCCode { get; set; }

        [Column("Customer Item No")]
        [MaxLength(30)]
        public string CustomerItemNo { get; set; }

        [Column("Item code")]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Column("Item Description")]
        [MaxLength(100)]
        public string ItemDescription { get; set; }

        [MaxLength(50)]
        public string Brand { get; set; }

        [Column("Sales Price")]
        public int? SalesPrice { get; set; }

        [Column("Quantity Sold")]
        public double? QuantitySold { get; set; }

        [Column("Unit Of Measure")]
        [MaxLength(30)]
        public string UnitOfMeasure { get; set; }

        [Column("Sale Date")]
        public DateTime? SaleDate { get; set; }

        [Column("Customer ID")]
        [MaxLength(30)]
        public string CustomerID { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }
    }
}
