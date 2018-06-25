using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting konnichiwa = new Greeting(name);
            return new JsonResult(konnichiwa);
        }
    }
}