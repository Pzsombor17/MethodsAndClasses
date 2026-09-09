using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Book
    {
        public static int Count = 0;
        private int pageCount { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get { return pageCount; } set { if (value < 0) { pageCount = 0; } else { pageCount = value; } } }
        public bool isAvailable { get; set; }

        public Book(string title, string author, int pageCount) : this(title, author)
        {
            this.Title = title;
            this.Author = author;
            this.pageCount = pageCount;
            Count++;
            this.isAvailable = true; ;
        }
        public Book(string title, string author)
        {
            this.pageCount = 0;
        }

        public void Describe()
        {
            Console.WriteLine($"Cím:{Title},szerző: {Author},oldalszám:{pageCount}");
        }
        public bool IsLong()
        {
            if (pageCount > 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Borrow()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("kikölcsönözted");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Return()
        {
            if (isAvailable = false)
            {
                isAvailable = true;
                Console.WriteLine("visszahozta");
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
