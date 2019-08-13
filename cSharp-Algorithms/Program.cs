using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharp_Algorithms.HackerRank;

namespace cSharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DayTwo ObjectReference
            DayTwo total = new DayTwo();
            total.InitialCost();
            #endregion

            #region DayThree Object Reference
            DayThree LoopCalled = new DayThree();
            LoopCalled.IfLoop(6);
            #endregion
            
            #region DayFour Object Reference
            DayFour Aging = new DayFour();
            Aging.Age(16);
            Aging.amIOld();
            Aging.yearPassing();
            #endregion
        }
    }
}
