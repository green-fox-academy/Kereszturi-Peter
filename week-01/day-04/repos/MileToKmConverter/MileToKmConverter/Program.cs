using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a distance:");
            int distance = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Your distance in miles is :" + distance * 0.621371192);

            Console.ReadLine();
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}
