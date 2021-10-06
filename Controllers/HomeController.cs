using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;
            
            ViewBag.Greeting = saat>12?"iyi günler":"Günaydın";
            ViewBag.User = "Doğukan";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}