using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet]
        public IActionResult GetSample()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSample(IFormCollection datas)
        {
            var value1 = datas["txtValue1"];
            var value2 = datas["txtValue2"];
            var value3 = datas["txtValue3"];

            return View();
        }
    }
}
