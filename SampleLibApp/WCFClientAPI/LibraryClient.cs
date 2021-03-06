﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.library.CommonClassLibrary;
using com.library.WCFClientAPI;
using System.ServiceModel;

namespace com.library.WCFClientAPI
{
    public class LibraryClient
    {
        LibraryServiceClient ls = null;
        string defaultendpoint = "net.tcp://localhost:9001/Library.svc";
        public LibraryClient():this("")
        {
        }

        public LibraryClient(string endpoint)
        {
            NetTcpBinding myBinding = new NetTcpBinding();
            myBinding.Security.Mode = SecurityMode.None;
            if (endpoint == "")
            {
                //Todo: read this from a file.
                endpoint = defaultendpoint;
            }
            EndpointAddress myEndpoint = new EndpointAddress(endpoint);

            ls = new LibraryServiceClient(myBinding, myEndpoint);
        }
        public List<Book> GetAllBooks()
        {
            return ls.GetAllBooks().ToList();
        }

        public Book GetBook(string isbn)
        {
            return ls.GetBook(isbn);
        }

        public bool AddNewBook(string isbn, string name, string author, string description) 
        {
            if(isbn == ""){
                throw new Exception("ISBN is required...!");
            }
            if (ls.GetBook(isbn) != null)
            {
                throw new Exception("ISBN already exist...!");
            }
            //if (name == "")
            //{
            //    throw new Exception("Name is required...!");
            //}
            //if (author == "")
            //{
            //    throw new Exception("Author is required...!");
            //}
            //if (description == "")
            //{
            //    throw new Exception("Description is required...!");
            //}

            Book book = new Book();
            book.Isbn = isbn;
            book.Name = name;
            book.Author = author;
            book.Description = description;
            return ls.AddNewBook(book);
        }

        public bool AddNewBook(Book book)
        {
            return ls.AddNewBook(book);
        }

        //public bool UpdateBook(Book book) 
        //{
        //    return ls.UpdateBook(book);
        //}
        public bool UpdateBook(string isbn, string name, string author, string description)
        {
            if (isbn == "")
            {
                throw new Exception("ISBN is required...!");
            }
            Book book = ls.GetBook(isbn);
            if (book == null)
            {
                throw new Exception("Wrong ISBN...!");
            }
            
            if (name.Length > 0)
            {
                book.Name = name;
            }
            if (author.Length > 0)
            {
                book.Author = author;
            }
            if (description.Length > 0)
            {
                book.Description = description;
            }
            return ls.UpdateBook(book);
        }

        public bool DeleteBook(string isbn)
        {
            if (isbn == "")
            {
                throw new Exception("ISBN is required...!");
            }            
            if (ls.GetBook(isbn) == null)
            {
                throw new Exception("Wrong ISBN...!");
            }
            return ls.DeleteBook(isbn);                
        }

        public bool IssueBook(string isbn, string empName)
        {
            if (isbn == "")
            {
                throw new Exception("ISBN is required...!");
            }
            Book book = ls.GetBook(isbn);
            if (book == null)
            {
                throw new Exception("Wrong ISBN...!");
            }
            if (book.Borrowed_by != "" && book.Borrowed_date != "")
            {
                throw new Exception("Book is already issued...!");
            }
            if (empName == "")   
            {
                throw new Exception("Employee Name is required...!");                                       
            }             
            return ls.IssueBook(isbn, empName);
        }

        public bool ReturnBook(string isbn)
        {
            if (isbn == "")
            {
                throw new Exception("ISBN is required...!");
            }
            Book book = ls.GetBook(isbn);
            if (book == null)
            {
                throw new Exception("Wrong ISBN...!");
            }
            else
            {
                if (book.Borrowed_by == "" && book.Borrowed_date == "")
                {
                    throw new Exception("Book is already returned...!");
                }
            }
            return ls.ReturnBook(isbn);
        }

        ~LibraryClient()
        {
            if (ls != null)
            {
                try
                {
                    if ((ls.State != CommunicationState.Faulted) && (ls.State != CommunicationState.Closed))
                    {
                        ls.Close();
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        ls.Abort();
                    }
                    catch (Exception) { }
                }
            }
        }

    }
}
