using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Location Setup")]
    public class LocationSetup
    {
        [Key]
        [Column("Location Code")]
        [MaxLength(30)]
        public string LocationCode { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Blocked { get; set; }

        public bool? Warehouse { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        [Column("Zip code")]
        public string ZipCode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}
