using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClientAPI.LibraryService;

namespace WCFClientAPI
{
    public class LibraryClient
    {
        ILibraryService ls;

        public LibraryClient()
        {
            ls = new LibraryServiceClient();
        }

        public Boolean AddBook(Book b)
        {
            return ls.AddBook(b);
        }

        public Boolean UpdateBook(Book b)
        {
            return ls.AddBook(b);
        }

        public bool DeleteBook(Book b)
        {
            return ls.DeleteBook(b);
        }

        public Book GetBook(int id)
        {
            return ls.GetBook(id);
        }

    }
}
