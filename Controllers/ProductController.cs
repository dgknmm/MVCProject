using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public string List()
        {
            return "product/list";
        }

        public string Details()
        {
            return "product/Details";
        }
    }
}