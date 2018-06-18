using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var n = from x in arrayOne
                    group x by x into y
                    select y;

            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }

            var frequencyMethod = arrayOne.ToDictionary(x => x.Key, x => x.ToList().Count);

            Console.ReadLine();
        }
    }
}
