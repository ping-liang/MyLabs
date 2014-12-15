using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace mvcdemo.Models
{
    [Table("employee")]
    public class Employee
    {
        public long Id { get; set; }
        [Column("name_first")]
        public string FirsName { get; set; }
        [Column("name_last")]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
