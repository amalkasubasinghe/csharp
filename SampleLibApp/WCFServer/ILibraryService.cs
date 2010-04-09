using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServer
{
    // TODO: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        bool AddBook(Book b);

        [OperationContract]
        bool UpdateBook(Book b);

        [OperationContract]
        bool DeleteBook(Book b);

        [OperationContract]
        Book GetBook(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class Book
    {
        int id = 0;
        string name = "";
        string author = "";
        string discription = "";

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        [DataMember]
        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }
    }
}
