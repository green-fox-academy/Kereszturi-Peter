using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpieClass firstSharpie = new SharpieClass("yellow", 11.5f);
            firstSharpie.Use();

            Console.WriteLine(firstSharpie.GetInkAmount());

            Console.ReadLine();
        }
    }
}
