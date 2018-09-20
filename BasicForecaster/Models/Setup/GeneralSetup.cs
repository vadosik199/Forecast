using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("General Setup")]
    public class GeneralSetup
    {
        [Key]
        [Column("Company No.")]
        public int CompanyNo { get; set; }

        [Column("Company Name")]
        public string CompanyName { get; set; }
    }
}
