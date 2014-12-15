using Microsoft.Data.Entity;
using System;
using Microsoft.Data.Entity.Metadata;
using System.Linq;

namespace CycleSales.Models
{
    public class CycleSalesContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
    }
}