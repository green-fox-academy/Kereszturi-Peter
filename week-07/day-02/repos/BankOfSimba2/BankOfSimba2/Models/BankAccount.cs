using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba2.Models
{
    public class BankAccount
    {
        public static int idCounter = 1;

        public BankAccount(string name, int balance, string animalType, bool isKing)
        {
            ID = idCounter;
            idCounter++;
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }

        public string Balancer()
        {
            return $"{Balance} Zebra";
        }
    }
}
