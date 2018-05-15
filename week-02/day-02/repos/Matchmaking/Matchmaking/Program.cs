using System;
using System.Collections.Generic;
using System.Text;

namespace Matchmaking
{
    public class Matchmaking
    {
        // Write a method that joins the two lists by matching one girl with one boy into a new list
        // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            Console.WriteLine(MakingMatches(girls, boys));

            Console.ReadLine();
        }
        public static StringBuilder MakingMatches(List<string> girls, List<string> boys)
        {
            StringBuilder boysAndGirls = new StringBuilder();

            for (int i = 0; i < girls.Count; i++)
            {
                boysAndGirls.Append(girls[i] + " ").Append(boys[i] + " ");
            }
            boysAndGirls.Append(boys[5]);
            return boysAndGirls;
        }
    }
}