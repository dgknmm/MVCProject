using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone x", Price = 6000, Description = "telefon" };
            ViewData["Category"] = "Telefonlar";
            ViewData["Product"] = product;

            return View();
        }

        public IActionResult List()
        {
            


            var products = new List<Product>()
            {
                new Product { Name = "Iphone 6", Price = 4000, Description = "iyi telefon" },
                new Product { Name = "Iphone 7", Price = 5000, Description = "telefon" ,isApproved=true},
                new Product { Name = "Iphone x", Price = 6000, Description = "telefon" },
                new Product { Name = "Iphone 11", Price = 7000, Description = "telefon",isApproved=true }
            };

            var productViewModel = new ProductViewmodel()
            {
                Products = products
            };
            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            // ViewBag.Name = "samsung s6";
            // ViewBag.Price = 3000;
            // ViewBag.Detail = "telefon";

            var p = new Product();
            p.Name = "samsung s6";
            p.Price = 3000;
            p.Description = "telefon";
            return View(p);
        }
    }
}