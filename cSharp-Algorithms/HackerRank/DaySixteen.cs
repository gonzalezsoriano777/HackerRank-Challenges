using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    class StringExceptions
    {
        public void stringException()
        {

            string S = Console.ReadLine();

            try
            {

                int numConversion = Int32.Parse(S);
                Console.WriteLine(numConversion);

            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
            }

        }
    }
}
