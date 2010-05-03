using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using com.library.CommonClassLibrary;
using com.library.DataAccess;
using System.Data.Linq;
using System.Diagnostics;

namespace com.library.DataAccessWithLinq
{
    public class DataAccessServiceWithLinq : IDataAccessService 
    {
        LibraryDataContext dc;
        TraceSource source;
        public DataAccessServiceWithLinq() 
        {            
            source = new TraceSource("com.library.DataAccessWithLinq");
            dc = new LibraryDataContext();
        }

        public List<Book> GetAllBooks()
        {
            List<Book> booksList = new List<Book>();
            try
            {
                source.TraceInformation("Getting all books");
                booksList = dc.Booktable.ToList<Book>();
                source.TraceInformation("Got all books");
            }
            catch (Exception e)
            {
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());
            }
            source.Flush();
            return booksList;   
        }

        public Book GetBook(string isbn) 
        {
            Book book = null;
            try
            {
                source.TraceInformation("Getting book:" + isbn);
                book = dc.Booktable.Single(b => b.Isbn == isbn);
                source.TraceInformation("Got book:" + isbn);
            }
            catch (Exception e)
            {
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());
            }
            source.Flush();
            return book;      
        }

        public bool AddNewBook(Book book) 
        {
            bool flag;
            try
            {
                if (GetBook(book.Isbn) == null)
                {
                    source.TraceInformation("Adding book:" + book.Name);
                    dc.Booktable.InsertOnSubmit(book);
                    dc.SubmitChanges();
                    source.TraceInformation("Added book:" + book.Name);
                    flag = true;
                }
                else
                {
                    throw new Exception("Book already exist");
                }
            }
            catch (Exception e)
            {
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());                
                flag = false;
            }
            source.Flush();
            return flag;
        }        

        public bool UpdateBook(Book book)
        {
            bool flag;
            try
            {
                Book toupdate = GetBook(book.Isbn);
                if (toupdate != null)
                {
                    source.TraceInformation("Updating book:" + book.Name);
                    Book entityBook = dc.Booktable.Single(b => b.Isbn == book.Isbn);
                    entityBook.Name = book.Name;
                    entityBook.Author = book.Author;
                    entityBook.Description = book.Description;
                    dc.SubmitChanges();
                    source.TraceInformation("Updateded book:" + book.Name);
                    flag = true;
                }
                else
                {
                    throw new Exception("Wrong Isbn ....");
                }
            }
            catch (Exception e)
            {
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());
                flag = false;
            }
            source.Flush();
            return flag;
        }

        public bool DeleteBook(string isbn)
        {
            bool flag;
            try
            {
                Book todelete = GetBook(isbn);
                if (todelete != null)
                {
                    source.TraceInformation("Deleting book:" + isbn);
                    Table<Book> books = dc.Booktable;
                    Book entityBook = dc.Booktable.Single(b => b.Isbn == isbn);
                    books.DeleteOnSubmit(entityBook);
                    dc.SubmitChanges();
                    flag = true;
                    source.TraceInformation("Deleted book:" + isbn);
                }
                else
                {
                    throw new Exception("Wrong Isbn ....");
                }
            }
            catch (Exception e)
            {
                flag = false;
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());
            }
            source.Flush();
            return flag;
        }

        public bool IssueBook(string isbn, string empName)
        {
            bool flag;
            try
            {
                source.TraceInformation("Issuing book:" + isbn);
                Book entityBook = dc.Booktable.Single(b => b.Isbn == isbn);
                entityBook.Borrowed_by = empName;
                entityBook.Borrowed_date = new DateTime().ToString();                
                dc.SubmitChanges();
                source.TraceInformation("Issued book" + isbn);
                flag = true;
            }
            catch (Exception e)
            {
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());
                flag = false;
            }
            source.Flush();
            return flag; 
        }

        public bool ReturnBook(string isbn)
        {
            bool flag;
            try
            {
                source.TraceInformation("Recieved book:" + isbn);
                Book entityBook = dc.Booktable.Single(b => b.Isbn == isbn);
                entityBook.Borrowed_by = "";
                entityBook.Borrowed_date = "";
                dc.SubmitChanges();
                source.TraceInformation("Received book" + isbn);
                flag = true;
            }
            catch (Exception e)
            {
                source.TraceEvent(TraceEventType.Error, 0, e.ToString());
                flag = false;
            }
            source.Flush();
            return flag;    
        }

        ~DataAccessServiceWithLinq()
        {
            try
            {
                source.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
