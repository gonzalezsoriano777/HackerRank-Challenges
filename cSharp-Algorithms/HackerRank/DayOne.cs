using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayOne
    {

        private int i = 12;
        private double d = 4.0;
        private string s = "Welcome to ";

        public void DataTypes()
        {
            int secondInt = Convert.ToInt32(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            string secondString = Convert.ToString(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", i, secondInt, i + secondInt);
            Console.WriteLine("{0:0.0}", d + secondDouble);
            Console.WriteLine(s + secondString);

        }
    }
}
