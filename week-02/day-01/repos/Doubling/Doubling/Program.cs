using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 123;

            Console.WriteLine(Doubling(baseNum));

            Console.ReadLine();
        }

        public static int Doubling(int baseNum)
        {
            return baseNum * 2;
        }
    }
}