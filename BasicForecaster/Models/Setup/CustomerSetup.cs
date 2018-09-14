using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Customer Setup")]
    public class CustomerSetup
    {
        [Column("Customer No")]
        [MaxLength(30)]
        public string CustomerNo { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Blocked { get; set; }

        [Column("POS Data Exist")]
        public bool? POSDataExist { get; set; }

        [Column("Customer Location Code")]
        [MaxLength(30)]
        public string CustomerLocationCode { get; set; }

        [Column("Customer buying Calendar")]
        [MaxLength(30)]
        public string CustomerBuyingCalendar { get; set; }

        [Column("Retailer Code")]
        [MaxLength(30)]
        public string RetailerCode { get; set; }
    }
}
