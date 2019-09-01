using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DaySix
    {
        public string wordParity(string word)
        {

            Console.WriteLine();
            Console.WriteLine("Word manipulation, grabbing odd and even characters: ");

            
                for (int firstWord = 0; firstWord < word.Length; firstWord++)
                {
                    if (firstWord % 2 == 0)
                    {
                        Console.Write(word[firstWord]);
                    }
                }

                Console.Write(" ");

                for(int secondWord = 0; secondWord < word.Length; secondWord++)
                {
                    if(secondWord % 2 == 1)
                    {
                        Console.Write(word[secondWord]);
                    }
                }

                Console.WriteLine();

            return word;
        }      
    }
}
