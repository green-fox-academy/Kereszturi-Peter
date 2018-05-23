using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal zebra = new Animal();
            zebra.Drink();
            Console.WriteLine(zebra.GetThirst());

            Animal monkey = new Animal();
            monkey.Play();
            Console.Write(monkey.GetThirst() + " " + monkey.GetHunger());

            Console.ReadLine();
        }
    }
}
