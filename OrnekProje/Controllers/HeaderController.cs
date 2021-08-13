using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class HeaderController : Controller
    {
        public IActionResult GetHeaderData()
        {

            var headers = Request.Headers.ToList(); // postman ile get requsti yaparak headres bilgisini urada görebiliriz.

            return View();
        }
    }
}
