using System;

namespace Sum
{
    class Program
    // - Write a function called `sum` that sum all the numbers
    //   until the given parameter and returns with an integer
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(11));

            Console.ReadLine();
        }
        public static int sum(int sumOne)
        {
            int sumTwo = 0;

            for (int i = 0; i < sumOne; i++)
            {
                sumTwo += i;
            }
            return sumTwo;
        }
    }
}