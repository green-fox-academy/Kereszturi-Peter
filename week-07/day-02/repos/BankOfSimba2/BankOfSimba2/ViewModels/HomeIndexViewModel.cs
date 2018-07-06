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
            new BankAccount("Timon", 100, "surikata"),
            new BankAccount("Pumba", 200, "warthog"),
            new BankAccount("Rafiki", 5000, "mandrill"),
            new BankAccount("Scar", 10000, "lion"),
            new BankAccount("Shenzi", 300, "hyena")
        };
    }
}
