using System;
using System.Collections.Generic;
using System.Text;

namespace CandyShop
{
    public class Candyshop
    {
        // Accidentally we added "2" and "false" to the list.
        // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
        // No, don't just remove the lines
        // Create a method called Sweets() which takes the list as a parameter.

        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);
                        
            Console.WriteLine(Sweets(list));

            Console.ReadLine();
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }
        public static string Sweets(List<object> sweetList)
        {
            sweetList[1].ToString();
            sweetList[1] = "Croissant";

            sweetList[3].ToString();
            sweetList[3] = "Ice cream";

            string correctSweets = "";

            foreach (var sweets in sweetList)
            {
                correctSweets += sweets + " ";
            }
            return correctSweets;
        }
    }
}