using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class Difference
    {
        private int[] elements;
        private int maximumDifference;
        
        public Difference(int[] element)
        {
            this.elements = element;
        }

        public int computeDifference()
        {
            maximumDifference = elements.Max() - elements.Min();
            return maximumDifference;
        }

    }
}
