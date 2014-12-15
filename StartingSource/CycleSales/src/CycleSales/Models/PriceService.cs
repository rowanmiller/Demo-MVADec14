using System;

namespace CycleSales.Models
{
    public class PriceService
    {
        private CycleSalesContext db;

        public PriceService(CycleSalesContext context)
        {
            db = context;
        }

        public void UpdatePrices(decimal multiplier)
        {
            foreach (var item in db.Bikes)
            {
                item.Retail *= multiplier;
            }

            db.SaveChanges();
        }
    }
}