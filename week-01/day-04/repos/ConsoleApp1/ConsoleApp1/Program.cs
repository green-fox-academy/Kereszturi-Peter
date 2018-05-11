using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfDoorsInACar = 5;
            int numberOfBuildingParts = 30_000;
            float price = 13_990_000.00f;
            bool permission = true;
            char energyLevel = 'B';
            string brand = "Mitshubishi";

            if (price < 1_000_000)
            {
                Console.WriteLine("Me gusta, me buy!");
            }
            else if (price < 5_000_000)
            {
                Console.WriteLine("Maybe next year");
            }
            else if (price > 10_000_000)
            {
                Console.WriteLine("No no no");
            }
            else
            {
                Console.WriteLine("Shit brah");
            }

            switch (energyLevel)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("This is very eco!");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Not so bad...");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Discount?");
                    break;
                default:
                    Console.WriteLine("Thanks no!");
                    break;
            }

            for (int i = 0; i < brand.Length; i++)
            {
                if (brand[i] == 'i')
                {
                    Console.WriteLine("This is the letter we are looking for " + brand[i] + " this is the best letter!");
                }
                else
                {
                    Console.WriteLine("Nope");
                }
            }

            Console.ReadLine();

        }
      
    }
}
