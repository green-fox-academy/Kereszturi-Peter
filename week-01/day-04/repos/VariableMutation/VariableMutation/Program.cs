using System;

namespace VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            a += 10;

            Console.WriteLine(a);

            int b = 100;

            b -= 7;

            Console.WriteLine(b);

            int c = 44;

            c = c * c;

            Console.WriteLine(c);

            int d = 125;

            d = d / 5;

            Console.WriteLine(d);

            int e = 8;

            e = e * e * e;

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool f3 = true;

            if (f1 > f2)
            {
                Console.WriteLine(f3);
            }
            else
            {
                f3 = false;
                Console.WriteLine(f3);
            }

            int g1 = 350;
            int g2 = 200;
            bool g3 = g1 < g2 * 2;

            Console.WriteLine(g3);
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            long h = 1357988018575474;

            bool h1 = h % 11 == 0;

            Console.WriteLine(h1);

            // tell if it has 11 as a divisor (print as a boolean)

            double i1 = 10;
            double i2 = 3;

            bool i3 = true;

            if (i1 > i2 * i2 && i2 * i2 *i2 > i1)
            {
                Console.WriteLine(i3);
            }
            else
            {
                i3 = false;
                Console.WriteLine(i3);
            }
            

            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;

            bool j1 = j % 3 == 0;
            bool j2 = j % 5 == 0;

            Console.WriteLine(j1);

            // tell if j is dividable by 3 or 5 (print as a boolean)

            string k = "Apple";

            Console.WriteLine(k + k + k + k + k);

            Console.ReadLine();
            }
        }
    }
