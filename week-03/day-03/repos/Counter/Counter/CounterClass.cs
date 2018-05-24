using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class CounterClass
    {
        private int startingNumber;

        public CounterClass()
        {
            startingNumber = 0;
        }

        public int Add()
        {
            return startingNumber++;
        }

        public int Add(int givenNumber)
        {
            return startingNumber += givenNumber;
        }

        public string Get()
        {
            return startingNumber.ToString();
        }

        public int Reset()
        {
            return 0;
        }
    }
}
