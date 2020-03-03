using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class DayEight
    {
        public void DictionaryAndMaps()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            var contactBook = new Dictionary<string, string>();

            for(int i = 0; i < num; i++)
            {
                var phoneBook = Console.ReadLine();
                var splitBook = phoneBook.Split();

                var name = splitBook[0];
                var phoneNum = splitBook[1];
                contactBook.Add(name, phoneNum);
            }

            for(int j = 0; j < num; j++)
            {
                string query = Console.ReadLine();
                if (contactBook.ContainsKey(query))
                {
                    var printName = contactBook[query];
                    Console.WriteLine("{0}={1}", query, printName);
                } else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
