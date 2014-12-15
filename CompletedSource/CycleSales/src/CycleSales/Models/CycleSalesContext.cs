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

        protected override void OnConfiguring(DbContextOptions options)
        {
            //options.UseSqlServer();// @"Server=.\SQLEXPRESS;Database=CycleSales;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>()
                .Property<DateTime>("LastUpdated");
        }

        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();

            foreach (var item in this.ChangeTracker.Entries<Bike>()
                .Where(e => e.State == EntityState.Modified))
            {
                // TODO: When supported, update to: item.Property("LastUpdated").CurrentValue = DateTime.Now;
                var prop = this.Model.GetEntityType(typeof(Bike)).GetProperty("LastUpdated");
                item.StateEntry[prop] = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}