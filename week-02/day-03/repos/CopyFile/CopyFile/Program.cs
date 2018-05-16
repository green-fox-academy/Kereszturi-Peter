using System;
using System.IO;

namespace CopyFile
{
    // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
    // It should take the filenames as parameters
    // It should return a boolean that shows if the copy was successful

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\greenfox\Plonee\week-02\day-03\repos\CopyFile\CopyFile\FileToCopyFrom.txt";
            Console.WriteLine(CopyFile(filePath));
            Console.ReadLine();
        }
        public static bool CopyFile(string filename)
        {
            string text = File.ReadAllText(filename);

            try
            {
                File.WriteAllText(@"D:\greenfox\Plonee\week-02\day-03\repos\CopyFile\CopyFile\FileToCopyTo.txt", text);
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
