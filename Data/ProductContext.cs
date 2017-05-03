using ProductsAspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAspNetCore.Data 
{
    public class ProductContext: DbContext 
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {

        }
        
        public DbSet<Product> Products { get; set; }
    }
}