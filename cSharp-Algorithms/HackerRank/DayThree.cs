using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayThree
    {
        public void Conditionals()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else if (N >= 2 && N < 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
