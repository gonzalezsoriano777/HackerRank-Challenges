using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.CodeSignal
{
    public class longestUnCorruptedSegments
    {
        public int[] longestUncorruptedSegments()
        {
            int[] unCorruptedSegments = new int[2];

            // testing array's streak of matching numbers and detecting any corrupted ( unmatching numbers )
            int[] sourceArray = new int[] { 33531593, 96933415, 28506400, 39457872, 29684716, 86010806 };
            int[] destinationArray = new int[] { 33531593, 96913415, 28506400, 39457872, 29684716, 86010806 };

            int counter = 0;
            int max = 0;

           

            return unCorruptedSegments; 
        }
    }
}
