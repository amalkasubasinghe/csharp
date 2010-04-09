using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsolDATest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=csharp-db;Integrated Security=True;Pooling=False");
                 
            //SqlDataReader rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                string insertString = @"insert into tbl_book(id, name, author, description) values (1, 'wicket', 'amalka', 'desc')";

                SqlCommand cmd = new SqlCommand(insertString, conn);

                //
                // 4. Use the connection
                //

                // get query results
                 cmd.ExecuteNonQuery();

                // print the CustomerID of each record
                //while (rdr.Read())
                //{
                //    Console.WriteLine(rdr[0]);
                //}
            }
            finally
            {
                // close the reader
                //if (rdr != null)
                //{
                //    rdr.Close();
                //}

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
    }
}
