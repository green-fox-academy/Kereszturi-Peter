using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    public class GreetingController : Controller
    {
        private IGreeting y;

        public GreetingController(IGreeting y)
        {
            this.y = y;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult UserInput(string name)
        {
            y.SetName(name);
            return RedirectToAction("Greetings");
        }

        [HttpGet]
        [Route("/greet")]
        public IActionResult Greetings()
        {
            object nev = y.GetName();
            return View(nev);
        }
    }
}