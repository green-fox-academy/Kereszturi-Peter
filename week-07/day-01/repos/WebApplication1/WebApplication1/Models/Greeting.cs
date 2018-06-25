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
        public string content { get; set; }

        public Greeting(string name)
        {
            content = name;
            ID = ID_ka++;
        }
    }
}
