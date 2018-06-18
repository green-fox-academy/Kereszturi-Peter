using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwearWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // There is a not so family friendly text in the `content.txt`
            // Create a function named FamilyFriendlizer that takes a filename and a list of strings as parameters
            // and remove all the given words from the file and returns the amount of the removed words.

            string path = @"D:\greenfox\Plonee\week-04\day-05\repos\Korep\SwearWords\SwearWords\content.txt";
            var offensiveWords = new List<string>() { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss" };
            Console.WriteLine(FamilyFriendlizer(path, offensiveWords)); // should print out 17

            Console.ReadLine();
        }

        private static int FamilyFriendlizer(string path, List<string> offensiveWords)
        {
            string[] readText;
            try
            {
                readText = File.ReadAllLines(path);
            }
            catch (DirectoryNotFoundException)
            {
                return 0;
            }

            int notNiceWords = 0;
            for (int i = 0; i < readText.Length; i++)
            {
                for (int j = 0; j < offensiveWords.Count; j++)
                {
                    readText[i] = readText[i].ToLower();

                    if (readText[i].Contains(offensiveWords[j]))
                    {
                        notNiceWords++;
                        readText[i] = readText[i].Replace(offensiveWords[j], "");
                    }
                }
            }

            File.WriteAllText(path, "");

            string lol = "";

            for (int i = 0; i < readText.Length; i++)
            {
                lol += readText[i];
            }

            File.AppendAllText(path, lol);

            return notNiceWords;
        }
    }
}
