using OrcClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcClub.Services
{
    public interface IOrcLife
    {
        void AddOrc(string name);
        Orc GetOrc(string name);
        string FeedTheOrc();
        string TeachTricks();
    }
}
