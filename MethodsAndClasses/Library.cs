using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Library
    {
        public string name { get; set; }
        private List<Book> books { get; set; }
        public int BookCount { get { return books.Count; } }

        public Library(string name)
        {
            name = name;
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void PrintAll()
        {
            foreach (Book book in books)
            {
                book.Describe();
            }
        }
        public Book FindBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }
       public int TotalPages() 
        {
            int totalPages = 0;
            foreach (Book book in books)
            {
                totalPages+=book.PageCount;
            }
            return totalPages;
        }
        public double AveragePages()
        {
            if (books.Count == 0)
            {
                return 0;
            }
            return (double)TotalPages() / books.Count;
        }
        public List<Book> GetBooksByAuthor(string author)
        {
            List<Book> booksByAuthor = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Author == author)
                {
                    booksByAuthor.Add(book);
                }
            }
            return booksByAuthor;
        }

        new List<Book> availableBooks = new List<Book>(); 
        public void AvailableBooks()
        {
            foreach (Book book in books)
            {
                if (book.isAvailable)
                {
                    availableBooks.Add(book);
                }
            }
 
        }

    }

}
