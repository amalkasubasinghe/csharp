﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.library.CommonClassLibrary
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/com.library.CommonClassLibrary")]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AuthorField;
        
        private string Borrowed_byField;
        
        private string Borrowed_dateField;
        
        private string DescriptionField;
        
        private string IsbnField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author
        {
            get
            {
                return this.AuthorField;
            }
            set
            {
                this.AuthorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Borrowed_by
        {
            get
            {
                return this.Borrowed_byField;
            }
            set
            {
                this.Borrowed_byField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Borrowed_date
        {
            get
            {
                return this.Borrowed_dateField;
            }
            set
            {
                this.Borrowed_dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Isbn
        {
            get
            {
                return this.IsbnField;
            }
            set
            {
                this.IsbnField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ILibraryService")]
public interface ILibraryService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAllBooks", ReplyAction="http://tempuri.org/ILibraryService/GetAllBooksResponse")]
    com.library.CommonClassLibrary.Book[] GetAllBooks();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBook", ReplyAction="http://tempuri.org/ILibraryService/GetBookResponse")]
    com.library.CommonClassLibrary.Book GetBook(string isbn);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddNewBook", ReplyAction="http://tempuri.org/ILibraryService/AddNewBookResponse")]
    bool AddNewBook(com.library.CommonClassLibrary.Book book);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/UpdateBook", ReplyAction="http://tempuri.org/ILibraryService/UpdateBookResponse")]
    bool UpdateBook(com.library.CommonClassLibrary.Book book);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteBook", ReplyAction="http://tempuri.org/ILibraryService/DeleteBookResponse")]
    bool DeleteBook(string isbn);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/IssueBook", ReplyAction="http://tempuri.org/ILibraryService/IssueBookResponse")]
    bool IssueBook(string isbn, string empName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/ReturnBook", ReplyAction="http://tempuri.org/ILibraryService/ReturnBookResponse")]
    bool ReturnBook(string isbn);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ILibraryServiceChannel : ILibraryService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class LibraryServiceClient : System.ServiceModel.ClientBase<ILibraryService>, ILibraryService
{
    
    public LibraryServiceClient()
    {
    }
    
    public LibraryServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public com.library.CommonClassLibrary.Book[] GetAllBooks()
    {
        return base.Channel.GetAllBooks();
    }
    
    public com.library.CommonClassLibrary.Book GetBook(string isbn)
    {
        return base.Channel.GetBook(isbn);
    }
    
    public bool AddNewBook(com.library.CommonClassLibrary.Book book)
    {
        return base.Channel.AddNewBook(book);
    }
    
    public bool UpdateBook(com.library.CommonClassLibrary.Book book)
    {
        return base.Channel.UpdateBook(book);
    }
    
    public bool DeleteBook(string isbn)
    {
        return base.Channel.DeleteBook(isbn);
    }
    
    public bool IssueBook(string isbn, string empName)
    {
        return base.Channel.IssueBook(isbn, empName);
    }
    
    public bool ReturnBook(string isbn)
    {
        return base.Channel.ReturnBook(isbn);
    }
}
