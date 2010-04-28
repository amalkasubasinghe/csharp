using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet(VerbsCommon.Add, "NewBook", SupportsShouldProcess = false)]
    public class AddNewBook:Cmdlet
    {
        private string _name = "mybook";

        /// <summary>name of the book</summary>
        [Alias("BookName")]
        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipelineByPropertyName = true
            )]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    
        protected override void ProcessRecord()
        {
            try
            {
                LibraryClient lc = new LibraryClient();
                Book b = new Book() { Isbn = "03", Author = "author3", Description = "powershell", Name = "name3" };
                bool added = lc.AddNewBook(b);
                if (added)
                {
                    WriteObject("Successfully Added the Book");
                }
                else
                {
                    throw new Exception("Book not added");
                }
            }
            catch ( Exception e )
            {
                WriteError(
                    new ErrorRecord(
                        e,
                        "AddBookException", 
                        ErrorCategory.NotSpecified, 
                        Name
                        )
                    );
            }
        }

    }

}
