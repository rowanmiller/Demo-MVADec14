using CycleSales.Controllers;
using CycleSales.Models;
using Microsoft.Data.Entity;
using System;
using Xunit;

namespace CycleSales.Tests
{
    public class BikeControllerTests
    {
        [Fact]
        public void Index_sorts__by_retail()
        {
            var options = new DbContextOptions<CycleSalesContext>()
                    .UseInMemoryStore();

            using (var db = new CycleSalesContext(options))
            {
                db.Bikes.Add(new Bike { Retail = 200 });
                db.Bikes.Add(new Bike { Retail = 100 });
                db.SaveChanges();

                var result = new BikeController(db).Index();
                Console.WriteLine(result);
            }
        }
    }
}
