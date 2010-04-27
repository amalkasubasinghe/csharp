using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using com.library.DataAccess;
using com.library.CommonClassLibrary;



namespace com.library.WCFServer
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class LibraryService : ILibraryService
    {

        #region ILibraryService Members

        public List<Book> GetAllBooks()
        {
            IDataAccessService das = new DataAccessService();
            return das.GetAllBooks();
        }

        public Book GetBook(string isbn)
        {
            IDataAccessService das = new DataAccessService();
            return das.GetBook(isbn);
        }

        public bool AddNewBook(Book book)
        {
            IDataAccessService das = new DataAccessService();
            return das.AddNewBook(book);            
        }

        public bool UpdateBook(Book book)
        {
            IDataAccessService das = new DataAccessService();
            return das.UpdateBook(book);        
        }

        public bool DeleteBook(string isbn)
        {
            IDataAccessService das = new DataAccessService();
            return das.DeleteBook(isbn);   
        }

        public bool IssueBook(string isbn, string empName)
        {
            IDataAccessService das = new DataAccessService();
            return das.IssueBook(isbn, empName);   
        }

        public bool ReturnBook(string isbn)
        {
            IDataAccessService das = new DataAccessService();
            return das.ReturnBook(isbn);   
        }
        #endregion
    }
}
