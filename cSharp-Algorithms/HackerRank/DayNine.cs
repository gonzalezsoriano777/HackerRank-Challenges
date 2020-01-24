using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayNine
    {
        public int Recursion(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n * Recursion(n - 1);
            }

        }

    }
}
