using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var cityNames = from i in cities
                            where i.StartsWith("A") && i.EndsWith("I")
                            select i;

            foreach (var item in cityNames)
            {
                Console.WriteLine(item);
            }

            var cityNamesMethod = cities.Where(x => x.StartsWith("A") && x.EndsWith("I"));

            foreach (var item in cityNamesMethod)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
