using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace com.library.CommonClassLibrary
{
    //public class Book
    //{
    //    private string isbn = "";
    //    private string name = "";
    //    private string author = "";
    //    private string description = "";
    //    private string borrowed_by = "";
    //    private string borrowed_date = "";

    //    public string Isbn
    //    {
    //        get { return isbn; }
    //        set { isbn = value; }
    //    }

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    public string Author
    //    {
    //        get { return author; }
    //        set { author = value; }
    //    }

    //    public string Description
    //    {
    //        get { return description; }
    //        set { description = value; }
    //    }

    //    public string Borrowed_by
    //    {
    //        get { return borrowed_by; }
    //        set { borrowed_by = value; }
    //    }

    //    public string Borrowed_date
    //    {
    //        get { return borrowed_date; }
    //        set { borrowed_date = value; }
    //    }
    //}
   

    [Table(Name = "tbl_book")]
    public class Book
    {
        private string isbn = "";
        private string name = "";
        private string author = "";
        private string description = "";
        private string borrowed_by = "";
        private string borrowed_date = "";

        [Column(IsPrimaryKey = true, Name = "isbn")]
        public string Isbn { 
            get { return isbn; } 
            set 
            {
                if (value != null)
                {
                    isbn = value.Trim();
                }
            } 
        }

        [Column(Name = "name")]
        public string Name { 
            get{return name;} 
            set 
            {
                if (value != null)
                { 
                    name = value.Trim(); 
                }
            }
        }

        [Column(Name = "author")]
        public string Author { 
            get{return author;} 
            set {
                if (value != null)
                {
                    author = value.Trim();
                }
            }
        }

        [Column(Name = "description")]
        public string Description
        {
            get { return description; }
            set
            {
                if (value != null)
                {
                    description = value.Trim();
                }
            }
        }
        [Column(Name = "borrowed_by")]
        public string Borrowed_by
        {
            get { return borrowed_by; }
            set
            {
                if (value != null)
                {
                    borrowed_by = value.Trim();
                }
            }
        }

        [Column(Name = "borrowed_date")]
        public string Borrowed_date
        {
            get { return borrowed_date; }
            set
            {
                if (value != null)
                {
                    borrowed_date = value.Trim();
                }
            }
        }
    }
}
