using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayTen
    {
        public void Binary()
        {
            List<int> binaryNum = new List<int>();
            int base10 = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int totalized = 0;


            List<int> count = new List<int>();

            while (base10 > 0)
            {
                int quotient = base10 / 2;
                int remainder = base10 % 2;
                base10 = quotient;

                binaryNum.Add(remainder);

            }
            binaryNum.Reverse();



            for (int index = 0; index < binaryNum.Count; index++)
            {

                if (binaryNum[index] == 1)
                {
                    counter++;
                    totalized = counter;
                    count.Add(totalized);
                }
                else
                    counter = 0;

            }
            count.Sort();
            count.Reverse();

            Console.WriteLine("NumberOfConsecutiveOnes:  {0}", count[0]);
        }
    }
}
