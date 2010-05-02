using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;
using System.Data.SqlClient;
using System.Threading;


namespace com.library.TestLibrary
{
    /// <summary>
    /// Summary description for ClientLibraryTest
    /// </summary>
    [TestClass]
    public class ClientLibraryTest
    {
        public ClientLibraryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public void TestSetup()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=csharp-db;Integrated Security=True;Pooling=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlComm = new SqlCommand("DELETE FROM tbl_book", conn);
                conn.Open();
                sqlComm.ExecuteNonQuery();
            }
        }

        [TestMethod]
        public void TestAddBookAsBook()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Book expectedBook = new Book() { Isbn = "01", Author = "author1", Description = "desc1", Name = "name1" };
            Assert.IsTrue(lc.AddNewBook(expectedBook));

            Book actualBook = lc.GetBook("01");
            Assert.AreEqual(expectedBook.Author, actualBook.Author);
            Assert.AreEqual(expectedBook.Name, actualBook.Name);
            Assert.AreEqual(expectedBook.Description, actualBook.Description);        
        }

        [TestMethod]
        public void TestAddBook()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Book actualBook = lc.GetBook("01");
            Assert.AreEqual("author1", actualBook.Author);
            Assert.AreEqual("name1", actualBook.Name);
            Assert.AreEqual("desc1", actualBook.Description);

            Assert.IsTrue(lc.AddNewBook("02", "name2", "author2", "desc2"));
            Assert.IsTrue(lc.AddNewBook("03", "", "author2", "desc3"));
            Assert.IsTrue(lc.AddNewBook("04", "name4", "", "desc4"));
            Assert.IsTrue(lc.AddNewBook("05", "name5", "author5", ""));
            try
            {
                lc.AddNewBook("01", "author2", "desc2", "name2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("ISBN already exist...!", e.Message);
            }
        }

     
        [TestMethod]
        public void TestGetAllBooks()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.AreEqual(0, lc.GetAllBooks().Count);
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Assert.IsTrue(lc.AddNewBook("02", "name2", "author2", "desc2"));
            List<Book> actualBooks = lc.GetAllBooks();
            Assert.AreEqual(2, actualBooks.Count);
            Assert.AreEqual("author1", actualBooks.ElementAt(0).Author);
            Assert.AreEqual("name1", actualBooks.ElementAt(0).Name);
            Assert.AreEqual("desc1", actualBooks.ElementAt(0).Description);
            Assert.AreEqual("author2", actualBooks.ElementAt(1).Author);
            Assert.AreEqual("name2", actualBooks.ElementAt(1).Name);
            Assert.AreEqual("desc2", actualBooks.ElementAt(1).Description);
        }

        [TestMethod]
        public void TestEditBook()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Assert.IsTrue(lc.AddNewBook("03", "name3", "author3", "desc3"));
            Assert.IsTrue(lc.UpdateBook("01", "name2", "author2", "desc2"));
            Book actualBook = lc.GetBook("01");
            Assert.AreEqual("author2", actualBook.Author);
            Assert.AreEqual("name2", actualBook.Name);
            Assert.AreEqual("desc2", actualBook.Description);

            Book actualBook3 = lc.GetBook("03");
            Assert.AreEqual("author3", actualBook3.Author);
            Assert.AreEqual("name3", actualBook3.Name);
            Assert.AreEqual("desc3", actualBook3.Description);

            try
            {
                lc.UpdateBook("", "name2", "author2", "desc2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("ISBN is required...!", e.Message);
            }

            try
            {
                lc.UpdateBook("456", "name2", "author2", "desc2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong ISBN...!", e.Message);
            }

        }

        [TestMethod]
        public void TestDeleteBook()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Assert.IsTrue(lc.AddNewBook("02", "name2", "author2", "desc2"));
            Assert.IsTrue(lc.AddNewBook("03", "name3", "author3", "desc3"));
            Assert.AreEqual(3, lc.GetAllBooks().Count);
            Assert.IsTrue(lc.DeleteBook("02"));
            Assert.AreEqual(2, lc.GetAllBooks().Count);
            Assert.AreEqual(null, lc.GetBook("02"));

            try
            {
                lc.DeleteBook("");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("ISBN is required...!", e.Message);
            }

            try
            {
                lc.DeleteBook("56");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong ISBN...!", e.Message);
            }

        }

        [TestMethod]
        public void TestLoad()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            string isbn;
            string name;
            string author;
            string description;

            for (int i = 0; i < 1000; i++)
            {
                isbn = "" + i;
                name = "name" + i;
                author = "author" + i;
                description = "description" + i;
                Assert.IsTrue(lc.AddNewBook(isbn, name, author, description));
            }

            List<Book> books = lc.GetAllBooks();
            Assert.AreEqual(1000, books.Count);
            Assert.AreEqual("123", lc.GetBook("123").Isbn);
            Assert.AreEqual("999", lc.GetBook("999").Isbn);
        }

        [TestMethod]
        public void TestIssueBook()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Assert.IsTrue(lc.AddNewBook("02", "name2", "author2", "desc2"));
            Assert.IsTrue(lc.AddNewBook("03", "name3", "author3", "desc3"));
            Assert.IsTrue(lc.IssueBook("01", "emp1"));
            Assert.IsTrue(lc.IssueBook("02", "emp1"));
            try
            {
                lc.IssueBook("01", "emp2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Book is already issued...!", e.Message);
            }

            try
            {
                lc.IssueBook("", "emp2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("ISBN is required...!", e.Message);
            }

            try
            {
                lc.IssueBook("werrwre", "emp2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong ISBN...!", e.Message);
            }

            try
            {
                lc.IssueBook("03", "");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Employee Name is required...!", e.Message);
            }

        }


        [TestMethod]
        public void TestReturnBook()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Assert.IsTrue(lc.AddNewBook("02", "name2", "author2", "desc2"));
            Assert.IsTrue(lc.AddNewBook("03", "name3", "author3", "desc3"));
            Assert.IsTrue(lc.IssueBook("01", "emp1"));
            Assert.IsTrue(lc.IssueBook("02", "emp1"));
            try
            {
                lc.IssueBook("02", "emp2");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Book is already issued...!", e.Message);
            }
            Assert.IsTrue(lc.ReturnBook("02"));
            Assert.IsTrue(lc.IssueBook("02", "emp2"));
            Assert.AreEqual("emp2", lc.GetBook("02").Borrowed_by);

            try
            {
                lc.ReturnBook("sdfsffd");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong ISBN...!", e.Message);
            }

            try
            {
                lc.ReturnBook("");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("ISBN is required...!", e.Message);
            }

            try
            {
                lc.ReturnBook("03");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Book is already returned...!", e.Message);
            }

        }

        [TestMethod]
        public void TestSecurity()
        {
            TestSetup();
            LibraryClient lc = new LibraryClient();
            Assert.IsTrue(lc.AddNewBook("01", "name1", "author1", "desc1"));
            Assert.IsTrue(lc.AddNewBook("02", "name2", "author2", "desc2"));
            Assert.IsTrue(lc.AddNewBook("03", "name3", "author3", "desc3"));
            try
            {
                Book b = lc.GetBook("03' ; DELETE FROM tbl_book; select * from tbl_book where isbn = '01");
            }
            catch (Exception)
            {
            }
            Assert.AreEqual(3,lc.GetAllBooks().Count);


            //makesure method parameter ISBN is not allowd to accept special characters.

            //maksure setting the book object parameters doesn't accept special characters.

        }

        [TestMethod]
        public void TestNumberOfConnections()
        {
            TestSetup();
            //Create 10 new threads which add 100 books with known ids to database.
            //check if database still have only 100 books.
            Thread[] ta = new Thread[50];
            for (int i = 0; i < ta.Length; i++)
            {
                ta[i] = new Thread(new ThreadStart(EntryPoint));
                ta[i].Name = "Thread_" + i;

            }

            foreach (Thread t in ta)
            {
                t.Start();
            }
            Thread.Sleep(5000);
            LibraryClient lc = new LibraryClient();
            List<Book> books = lc.GetAllBooks();
            Assert.AreEqual(10, books.Count);
            Assert.AreEqual("1", lc.GetBook("1").Isbn);
            Assert.AreEqual("9", lc.GetBook("9").Isbn);
            Assert.IsTrue(count>0);
        }

        public static int count = 0;

        public static void EntryPoint()
        {
          
            LibraryClient lc = new LibraryClient();
            string isbn;
            string name;
            string author;
            string description;

            for (int i = 0; i < 10; i++)
            {
                isbn = "" + i;
                name = "name" + i;
                author = "author" + i;
                description = "description" + i;
                try
                {
                    lc.AddNewBook(isbn, name, author, description);
                }
                catch (Exception) {
                    count++; 
                }

            }
            
        }

       
      }


    }
