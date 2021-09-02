using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class RouteController : Controller
    {
        public IActionResult GetRouteData(string id) //startup dosyasında bulunan defaultControllerRoute paramtresi olan Id değerini yakalama ...localhost:5001/route/getroutedata/8
        {
            return View();
        }


        [HttpGet]
        public IActionResult CustomRouteData(string a, string b, string c)
        {
            return View();
        }

    }
}
