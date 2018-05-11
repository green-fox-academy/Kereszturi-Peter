using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int avgCodingHours = 6;
            int semester = 17;
            int daysOfWork = semester * 5;
            double hoursSpentWithCoding = daysOfWork * avgCodingHours;
            double percentage = hoursSpentWithCoding / (52 * semester) *100;

            Console.WriteLine(hoursSpentWithCoding);

            Console.WriteLine(Convert.ToInt32(percentage) + " %");

            Console.ReadLine();


        }
    }
}
