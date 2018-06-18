using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> squaredMoreThan20 = from num in n
                                                 where num * num > 20
                                                 select num;
            foreach (var item in squaredMoreThan20)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> squarerMoreThan20Lambda = n.Where(x => x * x > 20);

            foreach (var item in squarerMoreThan20Lambda)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
