using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Controllers
{
    public class QueryController : Controller
    {
        public IActionResult GetQuery(string a, string b)
        {
            return View();
        }
    }
}
