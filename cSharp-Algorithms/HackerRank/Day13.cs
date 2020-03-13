using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }


    class myBook : Book
    {
        

    }
}
