using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductsAspNetCore.Models
{
    public class Product 
    {
        public int ID { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DisplayName("Kod kreskowy EAN")]
        public string EAN { get; set; }

        [DisplayName("Cena jednostkowa")]
        public double Price { get; set; }

        [DisplayName("Jednostka")]
        public string Unit { get; set; }

        [DisplayName("Stan magazynowy")]
        public int Availability { get; set; }
    }
}