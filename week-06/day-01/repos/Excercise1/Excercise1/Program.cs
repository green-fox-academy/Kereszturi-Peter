using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> numberQuery = from num in n
                                           where num % 2 == 0
                                           select num;

            foreach (var evenNumsQuery in numberQuery)
            {
                Console.WriteLine(evenNumsQuery);
            }

            IEnumerable<int> numberQueryWithLambda = n.Where(x => (x % 2 == 0));

            Console.WriteLine();

            foreach (var evenNumsMethod in numberQuery)
            {
                Console.WriteLine(evenNumsMethod);
            }

            Console.ReadLine();
        }
    }
}
