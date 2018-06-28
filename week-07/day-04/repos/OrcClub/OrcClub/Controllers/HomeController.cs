using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrcClub.Models;

namespace OrcClub.Controllers
{
    public class HomeController : Controller
    {

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
            return Redirect("/Info");
        }

        [HttpGet]
        [Route("/Info")]
        public IActionResult Info()
        {
            //object characterName = orc.GetName();
            return View();
        }
    }
}
