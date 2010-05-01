using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet(VerbsCommon.Set, "Book", SupportsShouldProcess = false)]
    public class UpdateBook : Cmdlet
    {
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

                bool updated = lc.UpdateBook(ISBN, BookName, Author, Description);
                if (updated)
                {
                    WriteObject("Successfully updated the book");
                }
                else
                {
                    throw new Exception("Book not updated");
                }
            }
            catch (Exception e)
            {
                WriteError(
                    new ErrorRecord(
                        e,
                        "UpdateBookException",
                        ErrorCategory.NotSpecified,
                        ISBN
                        )
                    );
            }
        }
    }  
}
