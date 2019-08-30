using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayThree
    {
        public void IfLoop(int num)
        {
            if(num % 2 == 1)
            {
                Console.WriteLine("Weird");
            }

            if(num % 2 == 0)
            {
                if (num >= 2 && num <= 5)
                {
                    Console.WriteLine("Not Weird");
                }

                    if (num >= 6 && num <= 20)
                    {
                        Console.WriteLine("Weird");
                    }
              
                        if(num > 20)
                        {
                            Console.WriteLine("Not Weird");
                        }

                Console.WriteLine();

            }
        }
    }
}
