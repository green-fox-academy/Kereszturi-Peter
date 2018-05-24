using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    class Program
    {
        // We have a number of bunnies and each bunny has two big floppy ears.
        // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfBunnyEars(4));
            Console.ReadLine();
        }

        public static int NumberOfBunnyEars(int numberOfBunnies)
        {
            if (numberOfBunnies == 0)
            {
                return 0;
            }
            else
            {
                return NumberOfBunnyEars(numberOfBunnies - 1) + 2;
            }
        }
    }
}
