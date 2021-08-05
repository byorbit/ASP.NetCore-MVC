using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct()
        {

            return View();
        }
    }
}
