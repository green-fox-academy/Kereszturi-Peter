using System;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean
            string name = "Keresztúri Péter";
            int age = 26;
            double height = 1.80;
            bool status = true;

            Console.WriteLine(name);

            Console.WriteLine(age);

            Console.WriteLine(height);

            if (status = true)
            {
                Console.WriteLine("Not married");
            }

            Console.ReadLine();
        }
    }
}
