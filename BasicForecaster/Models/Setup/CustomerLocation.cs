using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Customer Location")]
    public class CustomerLocation
    {
        [Key]
        [Column("Customer Location Code")]
        [MaxLength(30)]
        public string CustomerLocationCode { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Blocked { get; set; }

        [Column("POS Data Exist")]
        public double? POSDataExist { get; set; }

        [Column("Store No")]
        [MaxLength(30)]
        public string StoreNo { get; set; }
    }
}
