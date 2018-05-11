using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bmi = massInKg / heightInM;

            Console.WriteLine((int)bmi ^ 2);

            Console.ReadLine();
        }
    }
}
