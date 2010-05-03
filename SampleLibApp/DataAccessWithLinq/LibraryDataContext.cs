using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using com.library.CommonClassLibrary;

namespace com.library.DataAccessWithLinq
{
    public class LibraryDataContext:DataContext
    {
        public Table<Book> Booktable;
        public LibraryDataContext()
            : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=csharp-db;Integrated Security=True;Pooling=False")
        {
        }
    }
}
