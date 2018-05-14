using System;

namespace Factorials
{
    class Program
    // - Create a function called `factorio`
    //   that returns it's input's factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorio(6));

            Console.ReadLine();
        }
        public static int factorio(int factorials)
        {
            int numbersToFactor = 1;

            for (int i = 1; i < factorials; i++)
            {
                numbersToFactor *= i;
            }
            return numbersToFactor;
        }
    }
}