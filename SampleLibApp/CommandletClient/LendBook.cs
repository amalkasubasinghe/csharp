using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet("Lend","Book", SupportsShouldProcess = false)]
    public class LendBook : Cmdlet
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
        public string EmpName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            try
            {
                LibraryClient lc = new LibraryClient();

                bool updated = lc.IssueBook(ISBN, EmpName);
                if (updated)
                {
                    WriteObject("Successfully issued the book");
                }
                else
                {
                    throw new Exception("book can't be issued");
                }
            }
            catch (Exception e)
            {
                WriteError(
                    new ErrorRecord(
                        e,
                        "IssueBookException",
                        ErrorCategory.NotSpecified,
                        ISBN
                        )
                    );
            }
        }
    }  
}
