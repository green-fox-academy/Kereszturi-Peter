using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    public class SolarSystem
    {
        // Saturn is missing from the planetList
        // Insert it into the correct position
        // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
                        
            Console.WriteLine(PutSaturn(planetList));

            Console.ReadLine();
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
        }
        public static string PutSaturn(List<string> putThePlanetInTheString)
        {
            putThePlanetInTheString.Insert(5, "Saturn");
                        
            StringBuilder addSaturn = new StringBuilder();

            for (int i = 0; i < putThePlanetInTheString.Count; i++)
            {
                addSaturn.Append(putThePlanetInTheString[i] + " ");
            }
            return addSaturn.ToString();
        }
    }
}