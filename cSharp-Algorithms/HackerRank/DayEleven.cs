using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayEleven
    {
        public void TwoDimensionalArray()
        {
            int[][] arr = new int[6][];

            string stdin = "1 1 1 0 0 0 0 1 0 0 0 0 1 1 1 0 0 0 0 0 2 4 4 0 0 0 0 2 0 0 0 0 1 2 4 0 ";

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(stdin.Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            }

            int top, middle, bottom = 0;
            int counter = 0;
            var count = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    top = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    middle = arr[i + 1][j + 1];
                    bottom = arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    counter = top + middle + bottom;
                    count.Add(counter);
                }
            }

            count.Sort();
            count.Reverse();

            Console.WriteLine("{0}", count[0]);

                   
        }
    }
}
