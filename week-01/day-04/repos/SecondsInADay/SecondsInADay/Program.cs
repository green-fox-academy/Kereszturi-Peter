using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int remainingSeconds = 24 - currentHours * 60 * 60 + 1440 - currentMinutes * 60 + 86400 - currentSeconds;

            Console.WriteLine(remainingSeconds);

            Console.ReadLine();

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variable
        }
    }
}
