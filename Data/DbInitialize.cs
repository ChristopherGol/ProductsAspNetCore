using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using ProductsAspNetCore.Models;

namespace ProductsAspNetCore.Data 
{
    public static class DbInitialize
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            if(context.Products.Any()){
                return ;
            }

            var products=new List<Product>();
            products.Add(new Product{ Name="Chleb zwykły", EAN="569856325698", Price=2.65, Unit="sztuka", Availability=15 });
            products.Add(new Product{ Name="Bułka codzienna", EAN="653789512364", Price=0.35, Unit="sztuka", Availability=250 });
            products.Add(new Product{ Name="Mleko wiejskie", EAN="986321476589", Price=4.98, Unit="litr", Availability=30 });
            
            foreach(Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }   
    }
}