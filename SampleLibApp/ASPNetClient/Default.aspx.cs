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
using com.library.CommonClassLibrary;
using System.Text;

namespace com.library.ASPNetClient
{
    public partial class _Default : System.Web.UI.Page
    {
        public List<string> rows;
        LibraryClient lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> books = lc.GetAllBooks();

            rows = new List<string>();
            foreach (Book book in books)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("<tr><td>").Append(book.Isbn).Append("</td><td>")
                    .Append(book.Name).Append("</td><td>")
                    .Append(book.Author).Append("</td><td>")
                    .Append(book.Description).Append("</td><td>")
                    .Append(book.Borrowed_by).Append("</td><td>")
                    .Append(book.Borrowed_date).Append("</td><tr>");

                rows.Add(builder.ToString());
            }            

            
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
            lc = new LibraryClient();
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
                    lc.AddNewBook(txtIsbn.Text, txtName.Text, txtAuthor.Text, txtDescription.Text);                   
                }
                catch(Exception ex)                
                {
                    lblBookMessage.Text = ex.Message.ToString();
                    return;
                }
                lblBookMessage.Text = "Book Added Successfully...!";
                Page_Load(sender, e);
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    lc.UpdateBook(txtIsbn.Text, txtName.Text, txtAuthor.Text, txtDescription.Text);
                }
                catch (Exception ex)
                {
                    lblBookMessage.Text = ex.Message;
                }
                lblBookMessage.Text = "Book Updated Successfully...!";
                Page_Load(sender, e);
            }
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    lc.DeleteBook(txtIsbn.Text);
                }
                catch (Exception ex)
                {
                    lblBookMessage.Text = ex.Message;
                }
                lblBookMessage.Text = "Book Deleted Successfully...!";
                Page_Load(sender, e);
            }
        }

        protected void cmdIssue_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    lc.IssueBook(txtIssueIsbn.Text, txtEmpName.Text);
                }
                catch (Exception ex)
                {
                    lblIssueMessage.Text = ex.Message;
                }
                lblIssueMessage.Text = "Book Issued Successfully...!";
                Page_Load(sender, e);
            }
        }

        protected void cmdReturn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    lc.ReturnBook(txtIssueIsbn.Text);
                }
                catch (Exception ex)
                {
                    lblIssueMessage.Text = ex.Message;
                }
                lblIssueMessage.Text = "Book Returned Successfully...!";
                Page_Load(sender, e);
            }
        }

    }
}
