using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcClub.Services
{
    interface IOrcLife
    {
        string GetName();
        string SetName();
        string FeedTheOrc();
        string TeachTricks();
    }
}
