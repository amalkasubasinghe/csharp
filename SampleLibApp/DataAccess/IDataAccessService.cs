using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using com.library.CommonClassLibrary;



namespace com.library.DataAccess
{
    public interface IDataAccessService
    {
        List<Book> GetAllBooks();

        Book GetBook(string isbn);

        bool AddNewBook(Book book);

        bool UpdateBook(Book book);

        bool DeleteBook(string isbn);

        bool IssueBook(string isbn, string empName);

        bool ReturnBook(string isbn);
    }
 
}
