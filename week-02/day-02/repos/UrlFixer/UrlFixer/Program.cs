using System;

namespace UrlFixer
{
    public class UrlFixer
    {

        // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
        // Also, the URL is missing a crucial component, find out what it is and insert it too!
        // Try to solve it more than once using different string functions!

        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            url = url.Insert(5, ":");

            url = url.Replace("bots", "odds");

            Console.WriteLine(url);

            Console.ReadLine();
        }
    }
}