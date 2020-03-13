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


    class MyBook : Book
    {
        private int Price;

        public MyBook(string title, string author, int price)
                      :base(title, author)
        {
            this.Price = price;
        }

        public override void display()
        {
            Console.WriteLine("titleOfBook: {0}", title);
            Console.WriteLine("authorOfBook: {0}", author);
            Console.WriteLine("priceOfBook: {0}", Price);
        }
    
    }

    class Solution
    {
        static void MainFolder()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
