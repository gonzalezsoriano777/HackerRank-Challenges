using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayTwo
    {

        public void Operators(double mealCost, double tipPercent, double taxPercent)
        {
            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;

            Console.WriteLine(Math.Round(totalCost));
        }
    }
}
