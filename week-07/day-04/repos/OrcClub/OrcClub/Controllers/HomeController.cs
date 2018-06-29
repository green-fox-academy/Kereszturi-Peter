using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrcClub.Models;
using OrcClub.Services;

namespace OrcClub.Controllers
{
    public class HomeController : Controller
    {
        private IOrcLife orc;

        public HomeController(IOrcLife orc)
        {
            this.orc = orc;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Login(string input)
        {
            orc.AddOrc(input);
            return RedirectToAction("Info", input);
        }

        [HttpGet]
        [Route("/Info")]
        public IActionResult Info(string input)
        {

            return View(orc.GetOrc(input));
        }

        [HttpPost]
        [Route("/Info/Nutritionstore")]
        public IActionResult NutritionStore()
        {
            return View();
        }
    }
}
