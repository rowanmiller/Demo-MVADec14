using System;

namespace CycleSales.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string Name { get; set; }
        public string ModelNo { get; set; }
        public decimal Retail { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Features { get; set; }
    }
}