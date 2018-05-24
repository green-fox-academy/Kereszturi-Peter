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
            Console.WriteLine(CountDownRecursion(n));
            Console.ReadLine();
        }

        // Write a recursive function that takes one parameter: n and counts down from n.
        public static int CountDownRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(n);
                return CountDownRecursion(n - 1);
            }
        }
    }
}
