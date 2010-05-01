using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet("Return","Book", SupportsShouldProcess = false)]
    public class ReturnBook : Cmdlet
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

                bool returned = lc.ReturnBook(ISBN);
                if (returned)
                {
                    WriteObject("Successfully returned the book");
                }
                else
                {
                    throw new Exception("book can't be returned");
                }
            }
            catch (Exception e)
            {
                WriteError(
                    new ErrorRecord(
                        e,
                        "ReturnBookException",
                        ErrorCategory.NotSpecified,
                        ISBN
                        )
                    );
            }
        }
    }  
}
