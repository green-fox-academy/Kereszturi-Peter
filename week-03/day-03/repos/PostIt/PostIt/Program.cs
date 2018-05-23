using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt Idea1 = new PostIt("orange", "Idea 1", "blue");
            PostIt Awesome = new PostIt("pink", "Awesome", "black");
            PostIt Superb = new PostIt("yellow", "Superb", "green");

            Superb.WriteColor();
            Awesome.WriteText();

            Console.ReadLine();
        }

    }

    public struct PostIt
    {
        string BackgroundColor;
        string Text;
        string TextColor;

        public PostIt(string backgroundColor, string text, string textColor)
        {
            BackgroundColor = backgroundColor;
            Text = text;
            TextColor = textColor;
        }

        public void WriteColor()
        {
            Console.WriteLine(BackgroundColor);
        }

        public void WriteText()
        {
            Console.WriteLine(Text);
        }
    }

}
