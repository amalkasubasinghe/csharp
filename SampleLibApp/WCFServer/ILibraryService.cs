using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CommonClassLibrary;

namespace CST.WCFServer
{
    // TODO: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        List<Book> GetAllBooks();

        [OperationContract]
        Book GetBook(string isbn);

        [OperationContract]
        bool AddNewBook(Book book);

        [OperationContract]
        bool UpdateBook(Book book);

        [OperationContract]
        bool DeleteBook(string isbn);

        [OperationContract]
        bool IssueBook(string isbn, string empName);

        [OperationContract]
        bool ReturnBook(string isbn);
    } 
}
