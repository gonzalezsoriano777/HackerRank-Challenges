using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    class MoreExceptions
    {
        public int power(int n, int p)
        {

            if (n < 0 || p < 0)
                throw new Exception("n and p should be non-negative");

            double total = (int)Math.Pow(n, p);

            return (int)total;
        }
    }
}
