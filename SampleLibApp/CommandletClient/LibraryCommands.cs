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

        /// <summary>name of the book</summary>
        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipelineByPropertyName = true
            )]
        public string ISBN
        {
            get;
            set;
        }

        [Parameter(
            Mandatory = true,
            Position = 2,
            ValueFromPipelineByPropertyName = true
            )]
        public string BookName
        {
            get;
            set;
        }

        [Parameter(
            Mandatory = true,
            Position = 3,
            ValueFromPipelineByPropertyName = true
            )]
        public string Author
        {
            get;
            set;
        }

        [Parameter(
            Mandatory = true,
            Position = 4,
            ValueFromPipelineByPropertyName = true
            )]
        public string Description
        {
            get;
            set;
        }
    
        protected override void ProcessRecord()
        {
            try
            {
                LibraryClient lc = new LibraryClient();
               
                bool added = lc.AddNewBook(ISBN,BookName,Author,Description);
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
                        BookName
                        )
                    );
            }
        }

    }

}
