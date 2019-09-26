using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharp_Algorithms.HackerRank;
using cSharp_Algorithms.CodeSignal;

namespace cSharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region DayTwo ObjectReference
            DayTwo total = new DayTwo();
            total.InitialCost();
            #endregion

            #region DayThree ObjectReference
            DayThree LoopCalled = new DayThree();
            LoopCalled.IfLoop(6);
            #endregion
            
            #region DayFour ObjectReference
            DayFour Aging = new DayFour();
            Aging.Age(15);
            Aging.amIOld();
            Aging.yearPassing();
            #endregion

            #region DayFive ObjectReference
            DayFive IntegerLooping = new DayFive();
            IntegerLooping.Loops(2);
            #endregion

            #region DaySix ObjectReference
            DaySix WordParity = new DaySix();
            WordParity.wordParity("Hacker");
            #endregion


            #region DaySeven Reversing Array
            DaySeven arrReversing = new DaySeven();
            arrReversing.arrReverse();
            #endregion
            

            #region DayEight Dictionary&Maps
            DayEight phoneBook = new DayEight();
            phoneBook.ContactList();
            #endregion
            

            #region DayNine Recursion
            DayNine recursion = new DayNine();
            recursion.factorial(2);
            #endregion
            */

            longestUnCorruptedSegments match = new longestUnCorruptedSegments();
            match.longestUncorruptedSegments(new int[4] { 7, 2, 3, 5 }, new int[4] { 7, 2, 2, 7 });
            

        }

    }
}
