using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Please give us 5 numbers seperated by enter: ");

            for (int i = 0; i < 5; i++)
            {
                sum += Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum: " + sum + "\r\nAverage: " + sum / 5);

            Console.ReadLine();
        }
    }
}