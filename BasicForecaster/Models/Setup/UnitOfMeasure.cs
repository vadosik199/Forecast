using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("Unit of Measure")]
    public class UnitOfMeasure
    {
        [Column("Unit of Measure")]
        [MaxLength(30)]
        public string UnitofMeasure { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
    }
}
