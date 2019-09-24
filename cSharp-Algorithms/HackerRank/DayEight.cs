using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms
{
    public class DayEight
    {
        public void ContactList()
        {
            Console.WriteLine("This is a phone book carrying different names with different phone#'s");
            Console.WriteLine();

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            Console.WriteLine("Insert # Of Entries");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("# Of Entries: {0}", n);

            Console.WriteLine();
            Console.WriteLine("Enter Data : ");

            for(int record = 0; record < n; record++)
            {
                string entry = Console.ReadLine();
                string[] keyValues = entry.Split(' ');
                phoneBook.Add(keyValues[0], keyValues[1]);
            }

            for(int queries = 0; queries < n; queries++)
            {
                string query = Console.ReadLine();

                if(phoneBook.ContainsKey(query))
                {
                    string phoneNum = phoneBook[query];
                    Console.WriteLine("{0}={1}", query, phoneNum);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }


        }
    }
}
