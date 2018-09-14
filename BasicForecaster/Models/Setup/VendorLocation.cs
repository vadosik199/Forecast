using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Vendor Location")]
    public class VendorLocation
    {
        [Column("Vendor Location Code")]
        [MaxLength(30)]
        public string VendorLocationCode { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Blocked { get; set; }
    }
}
