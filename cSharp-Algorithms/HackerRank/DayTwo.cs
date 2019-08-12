using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayTwo
    {

        double meal_cost = 12;
        double tip_percent = 20;
        double tax_percent = 8;

        public void InitialCost()
        {

            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tip + tax;

            Console.WriteLine("The totalCost of my buffalo chicken sub meal is : ");
            Console.WriteLine(Math.Round(totalCost));
            Console.WriteLine();
           
        }
    }
}
