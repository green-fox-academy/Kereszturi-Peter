using OrcClub.Models;
using OrcClub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrcClub
{
    public class OrcService : IOrcLife
    {
        private List<Orc> orcList;

        public OrcService()
        {
            orcList = new List<Orc>();
        }

        public void AddOrc(string name)
        {
            Orc Garrosh = new Orc();
            Garrosh.Name = name;
            orcList.Add(Garrosh);
        }

        public Orc GetOrc(string name)
        {
            return orcList.Where(o => o.Name == name).Single();
        }

        public string FeedTheOrc()
        {
            throw new NotImplementedException();
        }

        public string TeachTricks()
        {
            throw new NotImplementedException();
        }
    }
}
