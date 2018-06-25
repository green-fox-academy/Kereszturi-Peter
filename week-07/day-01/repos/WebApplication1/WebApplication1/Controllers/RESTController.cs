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
            return View("asdf");
        }

        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting konnichiwa = new Greeting();
            konnichiwa.longID = 1;
            konnichiwa.content = "Hello World!";
            return new JsonResult(konnichiwa);
        }
    }
}