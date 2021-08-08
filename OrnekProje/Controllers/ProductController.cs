using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrnekProje.Models;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    { 
        //veri üretildi...
        [HttpGet]
        public IActionResult GetProducts(string ProductName, string Quantity)
        {   
            return View();
        }
       
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName, string txtQuantity)
        //{
        //    return View();
        //}
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
