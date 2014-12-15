using CycleSales.Models;
using Microsoft.Data.Entity;
using System;
using System.Linq;
using Xunit;

namespace CycleSales.Tests
{
    public class PriceServiceTests
    {
        [Fact]
        public void Simple_price_increase()
        {
            /*
            var options = new DbContextOptions<CycleSalesContext>()
                .UseSqlServer(@"Server=.\SQLEXPRESS;Database=TestDatabase;Trusted_Connection=True;");

            // Arrange
            using (var db = new CycleSalesContext(options))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                db.Bikes.Add(new Bike { Retail = 200 });
                db.Bikes.Add(new Bike { Retail = 100 });
                db.SaveChanges();
            }

            // Act
            using (var db = new CycleSalesContext(options))
            {
                var svc = new PriceService(db);
                svc.UpdatePrices(2);
            }

            // Assert
            using (var db = new CycleSalesContext(options))
            {
                Assert.True(db.Bikes.Any(b => b.Retail == 400));
                Assert.True(db.Bikes.Any(b => b.Retail == 200));
            }
            */
        }
    }
}
