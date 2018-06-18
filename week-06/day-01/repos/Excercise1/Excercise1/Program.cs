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

            IEnumerable<int> averageOfOddQuery = from number in n
                                                 where number % 2 != 0
                                                 select number;

            Console.WriteLine(averageOfOddQuery.Average());

            IEnumerable<int> averageOfOddMethod = n.Where(x => x % 2 != 0);

            Console.WriteLine(averageOfOddMethod.Average());

            IEnumerable<int> squareQuery = from numbers in n
                                           select numbers * numbers;

            foreach (var item in squareQuery)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> squareMethod = n.Select(x => x * x);

            foreach (var item in squareMethod)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
