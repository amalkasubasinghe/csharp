using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet(VerbsCommon.Remove, "Book", SupportsShouldProcess = false)]
    public class RemoveBook : Cmdlet
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

                bool deleted = lc.DeleteBook(ISBN);
                if (deleted)
                {
                    WriteObject("Successfully deleted the book");
                }
                else
                {
                    throw new Exception("Could not delete the book");
                }
            }
            catch (Exception e)
            {
                WriteError(
                    new ErrorRecord(
                        e,
                        "DeleteBookException",
                        ErrorCategory.NotSpecified,
                        ISBN
                        )
                    );
            }
        }
    }  
}
