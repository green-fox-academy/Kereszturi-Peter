using System;
using System.Text;

namespace Reverse
{
    public class Reverse
    {
        // Create a method that can reverse a String, which is passed as the parameter
        // Use it on this reversed string to check it!

        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            Console.WriteLine(Reversed(reversed));

            Console.ReadLine();
        }
        public static string Reversed(string reversedText)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int i = reversedText.Length -1; i >= 0; i--)
            {
                reversedString.Append(reversedText[i]);
            }
            return reversedString.ToString();
        }
    }
}