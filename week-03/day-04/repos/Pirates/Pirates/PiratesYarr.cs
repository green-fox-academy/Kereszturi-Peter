using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class PiratesYarr
    {
        private string pirateName;
        private int intoxicationLevel;

        public PiratesYarr(string pirateName)
        {
            this.pirateName = pirateName;
            intoxicationLevel = 0;
        }

        public int GetIntoxicationLevel()
        {
            return intoxicationLevel;
        }

        public int DrinkSomeRum()
        {
            return intoxicationLevel++;
        }

        public string HowsItGoingMate()
        {
            if (DrinkSomeRum() < 4)
            {
                return "Pour me anudder";
            }
            else
            {
                return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
            }
        }

        public string PassOut()
        {
            return pirateName + " is passed out!";
        }

        public void Die()
        {
            
        }

        public void Brawl()
        {

        }
    }
}
