using OrcClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcClub.Services
{
    public interface IOrcLife
    {
        //string GetName();
        //void SetName(string name);
        void AddOrc(string name);
        Orc GetOrc(string name);
        string FeedTheOrc();
        string TeachTricks();
    }
}
