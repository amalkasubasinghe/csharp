using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using com.library.CommonClassLibrary;

namespace com.library.DataAccess
{
    public class DataAccessService : IDataAccessService 
    {
        private SqlConnection conn = null;        

        public DataAccessService() 
        {            
            conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=csharp-db;Integrated Security=True;Pooling=False");
        }

        public List<Book> GetAllBooks()
        {
            SqlDataReader rdr = null;
            List<Book> books = new List<Book>();

            try
            {                
                conn.Open();                
                SqlCommand cmd = new SqlCommand("select * from tbl_book", conn);
                rdr = cmd.ExecuteReader();
                
                
                while (rdr.Read())
                {
                    Book b = new Book();
                    b.Isbn = (string)rdr[0];
                    b.Name = (string)rdr[1];
                    b.Author = (string)rdr[2];
                    b.Description = (string)rdr[3];
                    b.Borrowed_by = (string)rdr[4];
                    b.Borrowed_date = (string)rdr[5];

                    books.Add(b);
                }

            }
            finally
            {
                if (rdr != null) 
                {
                    rdr.Close();                        
                }                
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return books;   
        }

        public Book GetBook(string isbn) 
        {
            SqlDataReader rdr = null;
            Book book = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_book where isbn = '"+isbn+"'", conn);
                rdr = cmd.ExecuteReader();

                
                while (rdr.Read())
                {
                    book = new Book();
                    book.Isbn = (string)rdr[0];
                    book.Name = (string)rdr[1];
                    book.Author = (string)rdr[2];
                    book.Description = (string)rdr[3];
                    book.Borrowed_by = (string)rdr[4];
                    book.Borrowed_date = (string)rdr[5];                    
                }

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return book;      
        }

        public bool AddNewBook(Book book) 
        {            
            try
            {                
                conn.Open();                
                string insertString = @"insert into tbl_book(isbn, name, author, description) values ('"+book.Isbn+"', '"+book.Name+"', '"+book.Author+"', '"+book.Description+"')";              
                SqlCommand cmd = new SqlCommand(insertString, conn);                
                cmd.ExecuteNonQuery();
            }
            finally
            {                
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }

        public bool UpdateBook(Book book)
        {
            try
            {                
                conn.Open();                
                string updateString = @"update tbl_book set name = '"+book.Name+"', author = '"+book.Author+"', description = '"+book.Description+"' where isbn = '"+book.Isbn+"'";
                SqlCommand cmd = new SqlCommand(updateString, conn);                
                cmd.ExecuteNonQuery();
            }
            finally
            {                
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }

        public bool DeleteBook(string isbn)
        {
            try
            {                
                conn.Open();                
                string deleteString = @"delete from tbl_book where isbn = '"+isbn+"'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);                
                cmd.ExecuteNonQuery();
            }
            finally
            {                
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }

        public bool IssueBook(string isbn, string empName)
        {
            try
            {                
                conn.Open();                                
                string issueString = @"update tbl_book set borrowed_by = '" + empName + "', borrowed_date = '" + new DateTime() + "' where isbn = '" + isbn + "'";
                SqlCommand cmd = new SqlCommand(issueString, conn);                
                cmd.ExecuteNonQuery();
            }
            finally
            {                
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;    
        }

        public bool ReturnBook(string isbn)
        {
            try
            {                
                conn.Open();
                string returnString = @"update tbl_book set borrowed_by = '', borrowed_date = '' where isbn = '" + isbn + "'";
                SqlCommand cmd = new SqlCommand(returnString, conn);                
                cmd.ExecuteNonQuery();
            }
            finally
            {                
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;     
        }
    }
}
