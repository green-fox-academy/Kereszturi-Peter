﻿using System;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
        // Please fix it for me!
        // Expected ouput: In a galaxy far far away

        public static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            example = example.Replace("dishwasher", "galaxy");

            Console.WriteLine(example);

            Console.ReadLine();
        }
    }
}