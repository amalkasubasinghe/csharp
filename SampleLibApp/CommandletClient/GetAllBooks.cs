using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using com.library.WCFClientAPI;
using com.library.CommonClassLibrary;

namespace CommandletClient
{
    [Cmdlet(VerbsCommon.Get, "AllBooks", SupportsShouldProcess = false)]
    public class GetAllBooks : Cmdlet
    {

        protected override void ProcessRecord()
        {
            try
            {
                LibraryClient lc = new LibraryClient();
                List<Book> bookList = lc.GetAllBooks();
                if (bookList.Count() > 0)
                {
                    WriteObject(bookList);
                }
                else
                {
                    throw new Exception("Could not get the book list");
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
