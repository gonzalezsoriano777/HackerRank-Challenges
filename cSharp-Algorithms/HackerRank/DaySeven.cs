using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DaySeven
    {
        
        public void Arrays()
        {
            int[] numberArray = { 347, 19, 583, 83, 9, 3 };

            Array.Reverse(numberArray);

            foreach (int num in numberArray)
            {
                Console.WriteLine("{0}", num);
            }

        }
    }
}
