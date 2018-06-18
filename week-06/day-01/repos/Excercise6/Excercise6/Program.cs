using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string frequencyOfCharacters = "aaaaassssssdddddddddddddfffff";

            var n = from x in frequencyOfCharacters
                    group x by x into y
                    select y;

            foreach (var arrNo in n)
            {
                Console.WriteLine(arrNo.Key + " appears " + arrNo.Count() + " times");
            }

            Console.ReadLine();
        }
    }
}
