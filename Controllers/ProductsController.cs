using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsAspNetCore.Models;
using ProductsAspNetCore.Data;

namespace ProductsAspNetCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductContext context;

        public ProductsController(ProductContext _context)
        {
            context=_context;
        }
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }

    }
}
