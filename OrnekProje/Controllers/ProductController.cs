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
                
        //public IActionResult CreateProduct(string txtProductName, string txtQuantity)
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //ModelState: MVC'de bir type ın data annotationlarının durumunu kontrol eden ve geriye sonuc donduren property dir

            if (!ModelState.IsValid)
            {
                //Loglama
                //Kullanıcı bilgilendirme
                var messages = ModelState.ToList();


                return View(model); // Eger validasyondan geçilmemiş ise View'e bu mesajları gönderiyoruz

            }

            //Dogrulama yapılmış ve geçerli ise işlemler yapılır.
            return View();
        }
    }
}
