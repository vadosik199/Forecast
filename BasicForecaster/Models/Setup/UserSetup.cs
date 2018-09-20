using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Models.Setup
{
    [Table("User Setup")]
    public class UserSetup
    {
        [Key]
        [Column("User ID")]
        public string UserID { get; set; }

        [Column("First Name")]
        public string FirstName { get; set; }

        [Column("Middle Name")]
        public string LastName { get; set; }

        [Column("Last Name")]
        public string MiddleName { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("Permission")]
        public string Permission { get; set; }
    }
}
