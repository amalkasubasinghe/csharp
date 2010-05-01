using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet(VerbsCommon.Get, "Book", SupportsShouldProcess = false)]
    public class GetBook : Cmdlet
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

        protected override void ProcessRecord()
        {
            try
            {
                LibraryClient lc = new LibraryClient();
                Book book = lc.GetBook(ISBN);
                if (book != null)
                {
                    WriteObject(book);
                }
                else
                {
                    throw new Exception("Could not get the book");
                }
            }
            catch (Exception e)
            {
                WriteError(
                    new ErrorRecord(
                        e,
                        "GetAllBooksException",
                        ErrorCategory.NotSpecified, "GetAllBooks")
                    );
            }
        }

    }

}
