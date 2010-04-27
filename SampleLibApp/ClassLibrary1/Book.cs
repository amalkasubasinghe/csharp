using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.library.CommonClassLibrary
{
    public class Book
    {
        private string isbn = "";
        private string name = "";
        private string author = "";
        private string description = "";
        private string borrowed_by = "";
        private string borrowed_date = "";

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
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

        public string Borrowed_by
        {
            get { return borrowed_by; }
            set { borrowed_by = value; }
        }

        public string Borrowed_date
        {
            get { return borrowed_date; }
            set { borrowed_date = value; }
        }
    }
}
