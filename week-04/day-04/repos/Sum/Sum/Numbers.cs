using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Numbers
    {
        public int SumReturner(List<int> sumOfNumbers)
        {
            int sum = 0;

            for (int i = 0; i < sumOfNumbers.Count; i++)
            {
                sum += sumOfNumbers[i];
            }

            return sum;
        }
    }
}
