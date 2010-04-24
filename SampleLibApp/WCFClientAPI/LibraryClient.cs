using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonClassLibrary;

namespace WCFClientAPI
{
    public class LibraryClient
    {
        LibService.LibraryServiceClient ls = new LibService.LibraryServiceClient();

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            foreach(Book book in ls.GetAllBooks())
            {
                books.Add(book);
            }
            return books;
        }

        public Book GetBook(string isbn)
        {
            return ls.GetBook(isbn);
        }

        public bool AddNewBook(Book book)
        {
            return ls.AddNewBook(book);
        }

        public bool UpdateBook(Book book) 
        {
            return ls.UpdateBook(book);
        }

        public bool DeleteBook(string isbn)
        {
            return ls.DeleteBook(isbn);                
        }

        public bool IssueBook(string isbn, string empName)
        {
            return ls.IssueBook(isbn, empName);
        }

        public bool ReturnBook(string isbn)
        {
            return ls.ReturnBook(isbn);
        }

    }
}
