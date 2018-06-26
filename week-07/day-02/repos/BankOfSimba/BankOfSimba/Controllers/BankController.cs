using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("bank")]
    public class BankController : Controller
    {
        BankAccountAnimalViewModel baavm = new BankAccountAnimalViewModel()
        {
            BankAccountDatabase = new List<BankAccount>()
            {
                new BankAccount() {Name = "Simba", Balance = 2000, AnimalType = "lion" },
                new BankAccount() {Name = "Timon", Balance = 700, AnimalType = "meerkat"},
                new BankAccount() {Name = "Pumba", Balance = 700, AnimalType = "warthog"},
                new BankAccount() {Name = "Rafiki", Balance = 2000, AnimalType = "mandrill"},
                new BankAccount() {Name = "Nala", Balance = 10000, AnimalType = "lion"}
            }
        };

        public IActionResult Index()
        {
            BankAccount simbasAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion"
            };
            return View(simbasAccount);
        }

        [Route("account")]
        public IActionResult GetAccount()
        {
            return View(baavm);
        }

    }
}