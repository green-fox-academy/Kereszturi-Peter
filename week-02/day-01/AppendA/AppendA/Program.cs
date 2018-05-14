using System;

namespace AppendAFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";

            Console.WriteLine(appendA(am));

            Console.ReadLine();
        }

        public static string appendA(string ama)
        {
            return ama + "a";
        }
    }
}