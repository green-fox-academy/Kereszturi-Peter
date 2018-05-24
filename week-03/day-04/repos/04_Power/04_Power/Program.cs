using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        // Given base and n that are both 1 or more, compute recursively (no loops)
        // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

        static void Main(string[] args)
        {
            Console.WriteLine(Power(2, 2));
            Console.ReadLine();
        }

        public static int Power(int baseInt, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return baseInt * Power(baseInt, n - 1);
            }
        }
    }
}
