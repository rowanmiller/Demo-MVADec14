using Microsoft.Data.Entity;
using System;
using Microsoft.Data.Entity.Metadata;
using System.Linq;

namespace CycleSales.Models
{
    public class CycleSalesContext : DbContext
    {
        public CycleSalesContext(DbContextOptions<CycleSalesContext> options)
            : base(options)
        { }

        public DbSet<Bike> Bikes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>()
                .Property<DateTime>("LastUpdated");
        }

        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();

            foreach (var item in this.ChangeTracker.Entries<Bike>()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added))
            {
                // item.Property("LastUpdated").CurrentValue = DateTime.Now;
                var prop = this.Model.GetEntityType(typeof(Bike)).GetProperty("LastUpdated");
                item.StateEntry[prop] = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}