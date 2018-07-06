using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba2.Models;
using BankOfSimba2.ViewModels;

namespace BankOfSimba2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("simba")]
        public IActionResult Simba()
        {
            BankAccount simbasAccount = new BankAccount("Simba", 2000, "Lion");
            return View(simbasAccount);
        }

        [Route("animal")]
        public IActionResult AnimalAccounts()
        {
            return View(new HomeIndexViewModel());
        }
    }
}