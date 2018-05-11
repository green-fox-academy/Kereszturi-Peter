using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chickens does the farmer have?");
            int numOfChickens = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many pigs does the farmer have?");
            int numOfPigs = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The animals have " + (numOfChickens *2 + numOfPigs * 4) + " legs overall.");

            Console.ReadLine();

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
        }
    }
}
