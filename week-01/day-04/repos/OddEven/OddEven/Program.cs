using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadLine();
        }
    }
}
