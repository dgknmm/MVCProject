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
            ViewData["Category"]="Telefonlar";
            ViewData["Product"]=product;

            return View();
        }

        public string List()
        {
            return "product/list";
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