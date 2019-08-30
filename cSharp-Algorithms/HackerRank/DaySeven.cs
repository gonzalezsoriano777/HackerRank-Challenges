using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DaySeven
    {
        public void arrReverse()
        {
            Console.WriteLine();
            int[] arrLength = new int[5] { 1, 6, 4, 2, 6, };

            Array.Reverse(arrLength);

            foreach(int num in arrLength)
            {
           
                Console.Write(num + " ");
            }

            Console.WriteLine();

        }



    }
}
