using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DaySeven
    {
        
        public void ReverseArray()
        {
            int[] newArr = new int[4] { 4, 7, 1, 9 };

            Array.Reverse(newArr);

            foreach(int num in newArr)
            {
                Console.Write(num);
                Console.Write(" ");
            }

            Console.WriteLine();

        }
    }
}
