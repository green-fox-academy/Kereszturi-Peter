using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone
{
    public interface IGreeting
    {
        string GetName();
        void SetName(string name);
    }
}
