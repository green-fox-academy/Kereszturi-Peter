using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Greeting
    {
        public static long ID_ka = 1;
        public long ID { get; set; }
        public string Content { get; set; }

        public Greeting()
        {

        }

        public Greeting(string name)
        {
            Content = name;
            ID = ID_ka++;
        }

    }
}
