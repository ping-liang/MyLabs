using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}