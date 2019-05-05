using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BookStore
{
    using System.Collections;
    // Structure to describe book details
    public struct Book
    {
        private string Title;      // Title of the book
        private string Author;     // Author of the book
        private decimal Price;     // Price of the book  
        private bool Paperback;    // Is Paperback book

        public Book(string Title, string Author, decimal Price, bool Paperback)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
            this.Paperback = Paperback;
        }
    }

    // Declare a delegate of processsing book details (we can add any type like getting avg and count of books)
    public delegate void ProcessBookDelegate(ArrayList book);
 
    // Creating a class to store book details
    public class AddBooks
    {
        public ArrayList list = new ArrayList();
        // method to add books

        public AddBooks(string title, string author, decimal price, bool paperback)
        {
            list.Add(new Book(title, author, price, paperback));
        }

        public void ProcessPaperBackBooks(ProcessBookDelegate DelBook)
        {
            //foreach (Book book in list)
            //{
            //    if (book.Paperback)
            //        DelBook(book);
            //}
            //foreach (object obj in list)
            //{
               // if (((Book)obj).Paperback)
                    DelBook(list);
            //}
        }

        public static AddBooks AddBook(string title, string author, decimal price, bool paperback)
        {
            return new AddBooks(title, author, price, paperback);
        }
    }
}
