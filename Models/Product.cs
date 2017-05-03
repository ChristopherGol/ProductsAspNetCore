using System;

namespace ProductsAspNetCore.Models
{
    public class Product 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EAN { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public int Availability { get; set; }
    }
}