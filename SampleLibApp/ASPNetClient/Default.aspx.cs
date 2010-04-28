using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using com.library.WCFClientAPI;

namespace com.library.ASPNetClient
{
    public partial class _Default : System.Web.UI.Page
    {
        public List<string> names;
        protected void Page_Load(object sender, EventArgs e)
        {
            names = new List<string>();
            names.Add("amalka");
            names.Add("nadee");
            names.Add("suba");
            names.Add("manu");
            
        }

        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            this.cmdIssue.Click += new System.EventHandler(this.cmdIssue_Click);
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);

            this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion

        protected void cmdAdd_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) 
            {
                try
                {
                    LibraryClient lc = new LibraryClient();
                    lc.AddNewBook(txtIsbn.Text, txtName.Text, txtAuthor.Text, txtDescription.Text);                   
                }
                catch(Exception ex)                
                {
                    lblBookMessage.Text = ex.Message.ToString();
                    return;
                }
                lblBookMessage.Text = "Book Added Successfully...!";
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    LibraryClient lc = new LibraryClient();
                    lc.UpdateBook(txtIsbn.Text, txtName.Text, txtAuthor.Text, txtDescription.Text);
                }
                catch (Exception ex)
                {
                    lblBookMessage.Text = ex.Message;
                }
                lblBookMessage.Text = "Book Updated Successfully...!";
            }
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    LibraryClient lc = new LibraryClient();
                    lc.DeleteBook(txtIsbn.Text);
                }
                catch (Exception ex)
                {
                    lblBookMessage.Text = ex.Message;
                }
                lblBookMessage.Text = "Book Deleted Successfully...!";
            }
        }

        protected void cmdIssue_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    LibraryClient lc = new LibraryClient();
                    lc.IssueBook(txtIssueIsbn.Text, txtEmpName.Text);
                }
                catch (Exception ex)
                {
                    lblIssueMessage.Text = ex.Message;
                }
                lblIssueMessage.Text = "Book Issued Successfully...!";
            }
        }

        protected void cmdReturn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    LibraryClient lc = new LibraryClient();
                    lc.ReturnBook(txtIssueIsbn.Text);
                }
                catch (Exception ex)
                {
                    lblIssueMessage.Text = ex.Message;
                }
                lblIssueMessage.Text = "Book Returned Successfully...!";
            }
        }

    }
}
