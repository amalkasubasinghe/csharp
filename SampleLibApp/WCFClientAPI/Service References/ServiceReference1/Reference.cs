﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClientAPI.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILibraryService")]
    public interface ILibraryService {
        
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
    public interface ILibraryServiceChannel : WCFClientAPI.ServiceReference1.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<WCFClientAPI.ServiceReference1.ILibraryService>, WCFClientAPI.ServiceReference1.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public com.library.CommonClassLibrary.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public com.library.CommonClassLibrary.Book GetBook(string isbn) {
            return base.Channel.GetBook(isbn);
        }
        
        public bool AddNewBook(com.library.CommonClassLibrary.Book book) {
            return base.Channel.AddNewBook(book);
        }
        
        public bool UpdateBook(com.library.CommonClassLibrary.Book book) {
            return base.Channel.UpdateBook(book);
        }
        
        public bool DeleteBook(string isbn) {
            return base.Channel.DeleteBook(isbn);
        }
        
        public bool IssueBook(string isbn, string empName) {
            return base.Channel.IssueBook(isbn, empName);
        }
        
        public bool ReturnBook(string isbn) {
            return base.Channel.ReturnBook(isbn);
        }
    }
}
