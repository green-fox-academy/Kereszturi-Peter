using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Coutner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is: " + AddNumberToN(n));
            Console.ReadLine();
        }

        // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        public static int AddNumberToN(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + AddNumberToN(n - 1);
            }
        }
    }
}
