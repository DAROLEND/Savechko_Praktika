using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CandyStore.Models
{
    public class SweetContext : DbContext
    {
        public DbSet<Sweet> Sweets { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
