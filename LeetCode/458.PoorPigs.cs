using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            var Pigs = 0;
            if (buckets <= 1)
            {
                return Pigs;
            }

            var OnePigCanTestBukets = (minutesToTest / minutesToDie) + 1;
            double TotalCanTestBukets = 0;
            while (TotalCanTestBukets < buckets)
            {
                Pigs++;
                TotalCanTestBukets = Math.Pow(OnePigCanTestBukets, Pigs);
            }

            return Pigs;
        }
    }
}
