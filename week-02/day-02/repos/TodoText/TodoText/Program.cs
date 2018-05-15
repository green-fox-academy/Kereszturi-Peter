using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        // Add "My todo:" to the beginning of the todoText
        // Add " - Download games" to the end of the todoText
        // Add " - Diablo" to the end of the todoText but with indentation

        // Expected output:

        // My todo:
        //  - Buy milk
        //  - Download games
        //      - Diablo

        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            StringBuilder modifiedToDoText = new StringBuilder(todoText);

            modifiedToDoText = modifiedToDoText.Insert(0, "My todo:\n");

            modifiedToDoText = modifiedToDoText.Append(" - Download games");

            modifiedToDoText = modifiedToDoText.Append("\n\t - Diablo");

            Console.WriteLine(modifiedToDoText);

            Console.ReadLine();
        }
    }
}