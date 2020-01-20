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
            Dictionary<string, string> contactBook = new Dictionary<string, string>();
            int n = Convert.ToInt32(Console.ReadLine());

            for(int req = 0; req < n; req++)
            {
                var phoneBook = Console.ReadLine();
                var book = phoneBook.Split(' ');

                string name = book[0];
                string phone = book[1];
                contactBook.Add(name, phone);
                
            }

            for(int i = 0; i < n; i++)
            {
                string query = Console.ReadLine();

                if (contactBook.ContainsKey(query))
                {
                    var phone = contactBook[query];
                    Console.WriteLine("{0}={1}", query, phone);
                } else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}
