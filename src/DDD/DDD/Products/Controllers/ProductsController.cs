using DDD.Products.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Products.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Ice Cream", Price = 1.23m },
            new Product { Id = 2, Name = "Cake", Price = 2.34m }
        };

        public IActionResult Index()
        {
            return View(_products);
        }

        public IActionResult Details(int id)
        {
            var product = _products
                .First(p => p.Id == id);

            return View(product);
        }
    }
}
