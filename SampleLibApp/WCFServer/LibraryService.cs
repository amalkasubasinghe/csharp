using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using com.library.DataAccess;
using com.library.CommonClassLibrary;
using com.library.DataAccessWithLinq;
using System.Diagnostics;



namespace com.library.WCFServer
{
    
    public class LibraryService : ILibraryService
    {
        IDataAccessService das;
        public LibraryService()
        {
            //NOTE: you can use the "new DataAccessService()" here instead of DataAccessServiceWithLinq 
            //das = new DataAccessService();
            das = new DataAccessServiceWithLinq();
        }

        #region ILibraryService Members

        public List<Book> GetAllBooks()
        { 
            return das.GetAllBooks();
        }

        public Book GetBook(string isbn)
        {
            return das.GetBook(isbn);
        }

        public bool AddNewBook(Book book)
        {
            return das.AddNewBook(book);            
        }

        public bool UpdateBook(Book book)
        {
            return das.UpdateBook(book);        
        }

        public bool DeleteBook(string isbn)
        {
            return das.DeleteBook(isbn);   
        }

        public bool IssueBook(string isbn, string empName)
        {
            return das.IssueBook(isbn, empName);   
        }

        public bool ReturnBook(string isbn)
        {
            return das.ReturnBook(isbn);   
        }
        #endregion
    }
}
