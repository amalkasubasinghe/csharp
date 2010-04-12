using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServer
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class LibraryService : ILibraryService
    {

        #region ILibraryService Members

        public bool AddBook(Book b)
        {
            //TODO: Fix this
            return false;
        }

        public bool UpdateBook(Book b)
        {
            //TODO: Fix this
            return true;
        }

        public bool DeleteBook(Book b)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
