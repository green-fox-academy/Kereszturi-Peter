using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterClass counter1 = new CounterClass();
            counter1.Add(5);
            
            Console.WriteLine(counter1.Get());

            Console.ReadLine();
        }
    }
}
