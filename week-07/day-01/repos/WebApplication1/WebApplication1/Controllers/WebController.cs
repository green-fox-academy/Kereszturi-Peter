using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting(name);
            return View(greeting);
        }

        [Route("greetings/{name}")]
        public IActionResult GreetingsInLanguages(string name)
        {
            HelloInLanguages helloka = new HelloInLanguages() { Name=name };
            return View(helloka);
        }
    }
}