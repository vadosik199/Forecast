using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Sales Orders")]
    public class SalesOrders
    {
        [Column("Sales Order No")]
        [MaxLength(30)]
        public string SalesOrderNo { get; set; }

        [Column("Customer Code")]
        [MaxLength(30)]
        public string CustomerCode { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("Item Code")]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Column("Item Description")]
        [MaxLength(30)]
        public string ItemDescription { get; set; }

        [Column("Sales Price")]
        public int? SalesPrice { get; set; }

        public double? Quantity { get; set; }

        [Column("Unit Of Measure")]
        [MaxLength(30)]
        public string UnitOfMeasure { get; set; }

        [Column("Shipment Date ")]
        public DateTime? ShipmentDate { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }

        [Column("Location Code")]
        [MaxLength(30)]
        public string LocationCode { get; set; }

        [Column("Customer Location Code")]
        [MaxLength(30)]
        public string CustomerLocationCode { get; set; }

        [Column("Order date")]
        public DateTime? OrderDate { get; set; }
    }
}
