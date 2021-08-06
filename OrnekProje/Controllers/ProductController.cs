using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            Product product = new Product();
            //veri üretildi...

           // ViewResult result = View();
           //return result;

            return View(); //View fonksiyonu bu actiona ait(GetProducts) .cshtml dosyasını tetikleyecek fonksiyondur.
        }
    }
}
