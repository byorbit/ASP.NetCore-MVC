using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    //public class Model
    //{
    //    public string txtValue1 { get; set; }
    //    public string txtValue2 { get; set; }
    //    public string txtValue3 { get; set; }

    //}
    public class SampleController : Controller
    {
        [HttpGet]
        public IActionResult GetSample()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult GetSample(IFormCollection datas)
        //{
        //    var value1 = datas["txtValue1"].ToString();
        //    var value2 = datas["txtValue2"].ToString();
        //    var value3 = datas["txtValue3"].ToString();

        //    return View();
        //}
        public IActionResult GetSample(string txtValue1, string txtValue2, String txtValue3)
        {
            var value1 = txtValue1;
            var value2 = txtValue2;
            var value3 = txtValue3;

            return View();
        }

        //public IActionResult GetSample(Model model)
        //{
        //    return View();
        //}

    }
}