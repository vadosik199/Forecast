using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Sales Price Change History")]
    public class SalesPriceChangeHistory
    {
        [Key]
        [Column("Entry No.")]
        public string EntryNo { get; set; }

        [Column("Item No")]
        [MaxLength(30)]
        public string ItemNo { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("Customer Code")]
        [MaxLength(30)]
        public string CustomerCode { get; set; }

        [Column("Customer Description")]
        [MaxLength(100)]
        public string CustomerDescription { get; set; }

        [Column("Sales Price")]
        public int? SalesPrice { get; set; }

        [Column("Unit Of Measure")]
        [MaxLength(30)]
        public string UnitOfMeasure { get; set; }

        [Column("Shipment Date")]
        public DateTime? ShipmentDate { get; set; }

        [Column("Variant Code")]
        [MaxLength(30)]
        public string VariantCode { get; set; }
    }
}
