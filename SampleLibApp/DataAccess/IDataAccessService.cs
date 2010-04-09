using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;



namespace DataAccess
{
    public interface IDataAccessService
    {
        bool insertNewBook(Book book);

        bool insertNewEmployee(Employee employee);

        bool issueBook(String bookId, String employeeId);

        bool returnBook(String bookId);
    }
    
    public class Book
    {
        String id = "";
        string name = "";
        string author = "";
        string description = "";

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

    public class Employee
    {
        String id = "";
        String name = "";

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
