using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayFour
    {
        public int age;

        // defense system active.
        public DayFour(int initialAge)
        {
            if(initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0...");
            } else
            {
                age = initialAge;
            }
        }
        //--************--

        public void amIOld()
        {
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }

            if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }

            if (age >= 18)
            {
                Console.WriteLine("You are old.");
            }
        }
    }
}
