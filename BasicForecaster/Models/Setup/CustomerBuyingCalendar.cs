using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Customer Buying Calendar")]
    public class CustomerBuyingCalendar
    {
        [Column("Calendar Code")]
        [MaxLength(30)]
        public string CalendarCode { get; set; }

        [Column("Item Code")]
        [MaxLength(30)]
        public string ItemCode { get; set; }

        [Column("Item Description")]
        [MaxLength(100)]
        public string ItemDescription { get; set; }

        [Column("Quantity to buy")]
        public double? QuantityToBuy { get; set; }

        [Column("Unit Of Measure")]
        [MaxLength(30)]
        public string UnitOfMeasure { get; set; }

        [Column("Customer Location code")]
        [MaxLength(30)]
        public string CustomerLocationCode { get; set; }

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
