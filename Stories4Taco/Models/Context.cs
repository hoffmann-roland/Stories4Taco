using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=connectionString")
        {
        }

        public DbSet<Goal> Goals { get; set; }

        public DbSet<Release> Releases { get; set; }
    }
}