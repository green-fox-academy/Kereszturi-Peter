using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricAverage
{
    class Program
    {
        // Write a program that asks for a number.
        // It would ask this many times to enter an integer,
        // if all the integers are entered, it should print the sum and average of these
        // integers like:
        //
        // Sum: 22, Average: 4.4

        static void Main(string[] args)
        {
            int userNumber;
            double sumOfNumbers = 0;
            double averageOfNumbers;

            Console.WriteLine("Please enter a number!");
            userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter {0} numbers separated by enter!", userNumber);

            for (int i = 0; i < userNumber; i++)
            {
                sumOfNumbers += double.Parse(Console.ReadLine());
            }
            
            averageOfNumbers = sumOfNumbers / userNumber;

            Console.WriteLine("\nSum: {0}, Average: {1}", sumOfNumbers, averageOfNumbers);
            Console.ReadLine();
        }
    }
}
