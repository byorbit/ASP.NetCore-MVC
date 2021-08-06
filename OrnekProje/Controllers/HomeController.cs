using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class HomeController : Controller //Bir sınıfı request alabilir ve response dondurebilir yaani controller ypabilmek için o sınıfı Controller class'ından turetmemiz gerekmektedir.
    {
        public IActionResult Index()// controller sınıfları içinde yer alan tüm methodlar action metodu olarak anılır. action olması için controller içinde olmak zorundadır.
        {
            return View();
        }
    }
}
