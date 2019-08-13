using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayFive
    {
        public int Loops(int num)
        {
            
            for(int i = 1;  i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);    
            }

            return num;

        }
    }
}
