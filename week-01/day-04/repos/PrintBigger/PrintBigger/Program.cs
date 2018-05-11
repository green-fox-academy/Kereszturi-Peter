using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Please type in two numbers seperated by enter: ");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The bigger number is: " + num1);
            }
            else
            {
                Console.WriteLine("The bigger number is: " + num2);
            }

            Console.ReadLine();
        }
    }
}
