using System;

namespace _07_Strings
{
    class Program
    {
        // Given a string, compute recursively (no loops) a new string where all the
        // lowercase 'x' chars have been changed to 'y' chars.

        static void Main(string[] args)
        {
            Console.WriteLine(ChangeCharacterX("xoxo"));
            Console.ReadLine();
        }

        public static string ChangeCharacterX(string characterToChange)
        {
            if (characterToChange.Length == 0)
            {
                return "";
            }
            else
            {
                return characterToChange.Replace("x", "y") + ChangeCharacterX(characterToChange.Remove(0));
            }
        }
    }
}
