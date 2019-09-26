using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.CodeSignal
{
    public class longestUnCorruptedSegments
    {

        // testing array's streak of matching numbers and detecting any corrupted ( unmatching numbers )
        public int[] longestUncorruptedSegments(int[] sourceArray, int[] destinationArray)
        {
            int[] unCorruptedSegments = new int[2];           

            int counter = 0;
            int max = 0;

            for(int i = 0; i < sourceArray.Length; i++)
            {

                if(sourceArray[i] == destinationArray[i])
                {
                    counter++;

                    if (counter < max)
                    {
                        max = counter;
                        unCorruptedSegments[0] = max;
                    }

                    if(counter == 1)
                    {
                        unCorruptedSegments[1] = i;
                    }
                }
                else
                {
                    counter = 0;
                }

            }

           

            return unCorruptedSegments; 
        }
    }
}
