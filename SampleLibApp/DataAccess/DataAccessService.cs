using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    class DataAccessService : IDataAccessService 
    {
        private SqlConnection conn = null;        

        public DataAccessService() 
        {
            // 1. Instantiate the connection
            conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=csharp-db;Integrated Security=True;Pooling=False");
        }

        public bool insertNewBook(Book book) 
        {            
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object                
                string insertString = @"insert into tbl_book(id, name, author, description) values ('"+book.Id+"', '"+book.Name+"', '"+book.Author+"', '"+book.Description+"')";              
                SqlCommand cmd = new SqlCommand(insertString, conn);

                // execute the command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }

        public bool insertNewEmployee(Employee employee)
        {
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object                
                string insertString = @"insert into tbl_employee(id, name) values ('" + employee.Id + "', '" + employee.Name + "')";
                SqlCommand cmd = new SqlCommand(insertString, conn);

                // execute the command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;    
        }

        public bool issueBook(String bookId, String employeeId)
        {
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object                
                string insertString = @"insert into tbl_borrowings(book_id, employee_id, borrowed_date, returned_date) values ('" + bookId+ "', '" + employeeId + "','"+new DateTime()+"','')";
                SqlCommand cmd = new SqlCommand(insertString, conn);

                // execute the command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;     
        }

        public bool returnBook(String bookId) 
        {
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object 
                string updateString = @"update tbl_borrowings set returned_date = '" + new DateTime() + "' where book_id = '"+bookId+"' and returned_date = ''";                
                SqlCommand cmd = new SqlCommand(updateString, conn);
                
                // execute the command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;      
        }
    }
}
