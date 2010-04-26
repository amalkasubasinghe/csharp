using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.ComponentModel;

namespace CommandletClient
{
    [RunInstaller(true)]
    public class PSBookLibrarySnapIn : PSSnapIn
    {

        public override string Description
        {
            get { return "This Windows PowerShell snap-in contains methods for manipulating books in CSLLibrary"; }
        }

        public override string Name
        {
            get { return "CST.BookLibrary.PSClient"; }
        }

        public override string Vendor
        {
            get { return "CST"; }
        }
    }
}
