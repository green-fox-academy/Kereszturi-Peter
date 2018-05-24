using System;

namespace _06_BunniesAgain
{
    class Program
    {
        // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
        // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
        // have 3 ears, because they each have a raised foot. Recursively return the
        // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfBunnyEars(0));
            Console.ReadLine();
        }

        public static int NumberOfBunnyEars(int numberOfBunnies)
        {
            if (numberOfBunnies == 0)
            {
                return 0;
            }
            else if (numberOfBunnies % 2 == 0)
            {
                return NumberOfBunnyEars(numberOfBunnies - 1) + 3;
            }
            else
            {
                return NumberOfBunnyEars(numberOfBunnies - 1) + 2;
            }
        }
    }
}
