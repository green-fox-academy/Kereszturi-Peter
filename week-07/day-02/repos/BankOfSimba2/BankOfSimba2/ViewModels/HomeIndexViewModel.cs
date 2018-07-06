using BankOfSimba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba2.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<BankAccount> accountsOfAnimals = new List<BankAccount>()
        {
            new BankAccount("Timon", 100, "surikata", false),
            new BankAccount("Pumba", 200, "warthog", false),
            new BankAccount("Rafiki", 5000, "mandrill", false),
            new BankAccount("Scar", 10000, "lion", true),
            new BankAccount("Shenzi", 300, "hyena", false),
            new BankAccount("Mufasa", 5000, "lion", true)
        };
    }
}
