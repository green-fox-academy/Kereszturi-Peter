using System;
using System.Collections.Generic;
using System.IO;

namespace Logs
{
    // Read all data from 'log.txt'.
    // Each line represents a log message from a web server
    // Write a function that returns an array with the unique IP adresses.
    // Write a function that returns the GET / POST request ratio.

    class Program
    {
        static void Main(string[] args)
        {
            string logNewText = @"D:\greenfox\Plonee\week-02\day-03\repos\Logs\Logs\log.txt";
            Console.WriteLine("The unique IP adresses are: ");
            foreach (var item in ReturnIPAdresses(logNewText))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            GetPostRatio(logNewText);
            Console.ReadLine();
        }

        public static string[] ReturnIPAdresses(string logNewText)
        {
            
            List<string> listOfUniqueIP = new List<string>();
            int index = 0;
            string line = "";

            while (line != null)
            {
                line = File.ReadAllText(logNewText);
                if (line != null)
                {
                    if (listOfUniqueIP.Contains(line.Substring(27, 11)) != true)
                    {
                        listOfUniqueIP.Add(line.Substring(27, 11));
                        index += 1;
                    }
                }
            }
            return listOfUniqueIP.ToArray();
        }
        public static void GetPostRatio(string logNewText)
        {
            string ratioOfRequests = File.ReadAllText(@"D:\greenfox\Plonee\week-02\day-03\repos\Logs\Logs\log.txt");
            List<string> listOfRatios = new List<string>();
            string line = "";
            int numberOfGet = 0;
            int numberOfPost = 0;

            while (line != null)
            {
                line = File.ReadAllText(ratioOfRequests);
                if (line != null)
                {
                    if (listOfRatios.Contains("POST /") != true)
                    {
                        numberOfPost += 1;
                    }
                    else if (listOfRatios.Contains("GET /") != true)
                    {
                        numberOfGet += 1;
                    }
                }
            }
            Console.WriteLine("The Get /Post ratio is: {0} / {1}", numberOfGet, numberOfPost );
        }
    }
}
