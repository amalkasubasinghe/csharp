﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/com.library.CommonClassLibrary")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Borrowed_byField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Borrowed_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IsbnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Borrowed_by {
            get {
                return this.Borrowed_byField;
            }
            set {
                if ((object.ReferenceEquals(this.Borrowed_byField, value) != true)) {
                    this.Borrowed_byField = value;
                    this.RaisePropertyChanged("Borrowed_by");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Borrowed_date {
            get {
                return this.Borrowed_dateField;
            }
            set {
                if ((object.ReferenceEquals(this.Borrowed_dateField, value) != true)) {
                    this.Borrowed_dateField = value;
                    this.RaisePropertyChanged("Borrowed_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Isbn {
            get {
                return this.IsbnField;
            }
            set {
                if ((object.ReferenceEquals(this.IsbnField, value) != true)) {
                    this.IsbnField = value;
                    this.RaisePropertyChanged("Isbn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAllBooks", ReplyAction="http://tempuri.org/ILibraryService/GetAllBooksResponse")]
        TestService.ServiceReference1.Book[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBook", ReplyAction="http://tempuri.org/ILibraryService/GetBookResponse")]
        TestService.ServiceReference1.Book GetBook(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddNewBook", ReplyAction="http://tempuri.org/ILibraryService/AddNewBookResponse")]
        bool AddNewBook(TestService.ServiceReference1.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/UpdateBook", ReplyAction="http://tempuri.org/ILibraryService/UpdateBookResponse")]
        bool UpdateBook(TestService.ServiceReference1.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteBook", ReplyAction="http://tempuri.org/ILibraryService/DeleteBookResponse")]
        bool DeleteBook(string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/IssueBook", ReplyAction="http://tempuri.org/ILibraryService/IssueBookResponse")]
        bool IssueBook(string isbn, string empName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/ReturnBook", ReplyAction="http://tempuri.org/ILibraryService/ReturnBookResponse")]
        bool ReturnBook(string isbn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ILibraryServiceChannel : TestService.ServiceReference1.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<TestService.ServiceReference1.ILibraryService>, TestService.ServiceReference1.ILibraryService {
        
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
        
        public TestService.ServiceReference1.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public TestService.ServiceReference1.Book GetBook(string isbn) {
            return base.Channel.GetBook(isbn);
        }
        
        public bool AddNewBook(TestService.ServiceReference1.Book book) {
            return base.Channel.AddNewBook(book);
        }
        
        public bool UpdateBook(TestService.ServiceReference1.Book book) {
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