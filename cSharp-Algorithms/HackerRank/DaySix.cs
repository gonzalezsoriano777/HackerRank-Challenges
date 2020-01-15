using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DaySix
    {
        public void LetsReview()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int test = 0; test < T; test++)
            {
                string S = Console.ReadLine();

                for (int i = 0; i < S.Length; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(S[i]);
                    }
                }

                Console.Write(" ");

                for(int j = 0; j < S.Length; j++)
                {
                    if(j % 2 == 1)
                    {
                        Console.Write(S[j]);
                    }
                }

                Console.WriteLine();
               
            }

        }
    }
}
