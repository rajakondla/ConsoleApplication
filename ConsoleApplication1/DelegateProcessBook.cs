using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    using BookStore;
    using System.Collections;
    // class to add and average books
    //class AddBooksAverage
    //{
    //    int countBooks = 0; // for counting no of books
    //    decimal price = 0.0m; // price to find total price of all books

    //    // for counting and adding price
    //    internal void BookCountAvg(ArrayList list)
    //    {
    //        foreach (object obj in list)
    //        {
    //            countBooks += 1;
    //           // price += ((BookStore.Book)obj).
    //        }
    //    }

    //    // for getting average price of books
    //    internal decimal Average
    //    {
    //        get
    //        {
    //            return price / countBooks;
    //        }
    //    }
    //    // for getting count of books
    //    internal decimal Count
    //    {
    //        get
    //        {
    //            return countBooks;
    //        }
    //    }
    //}

    //class TestBookDelegate
    //{
    //    // this client code does not know how the database of books is maintained 
    //   // The use of delegates promotes good separation of functionality between the bookstore database
    //    //and the client code. The client code has no knowledge of how the books are stored or how the 
    //    //bookstore code finds paperback books. The bookstore code has no knowledge of what processing 
    //    //is done on the paperback books after it finds them.
    //    public void Add(AddBooks add)
    //    {
    //        add.AddBook("The C Programming Language",
    //        "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
    //        add.AddBook("The Unicode Standard 2.0",
    //           "The Unicode Consortium", 39.95m, true);
    //        add.AddBook("The MS-DOS Encyclopedia",
    //           "Ray Duncan", 129.95m, false);
    //        add.AddBook("Dogbert's Clues for the Clueless",
    //           "Scott Adams", 12.00m, true);
    //    }

    //    static void Main()
    //    {
    //        AddBooks addbooks = new AddBooks();
    //        TestBookDelegate testbook = new TestBookDelegate();
    //        testbook.Add(addbooks);
    //        AddBooksAverage addbookavg = new AddBooksAverage();
    //        addbooks.ProcessPaperBackBooks(addbookavg.BookCountAvg);
    //        Console.WriteLine("{0} present in the store.",addbooks.list.Count);
    //        Console.WriteLine("{0} paper back books.",addbookavg.Count);
    //        Console.WriteLine("Avg price of each paper back book is ${0:#.##}", addbookavg.Average);
    //        Console.WriteLine("Avg price of each paper back book is {0}", addbookavg.Average);
    //    }
    //}
}
