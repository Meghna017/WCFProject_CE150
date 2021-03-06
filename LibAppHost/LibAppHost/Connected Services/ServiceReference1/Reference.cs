﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibAppHost.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        LibrarySystemService.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        System.Threading.Tasks.Task<LibrarySystemService.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBook", ReplyAction="http://tempuri.org/IService1/GetBookResponse")]
        LibrarySystemService.Book[] GetBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBook", ReplyAction="http://tempuri.org/IService1/GetBookResponse")]
        System.Threading.Tasks.Task<LibrarySystemService.Book[]> GetBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookByName", ReplyAction="http://tempuri.org/IService1/GetBookByNameResponse")]
        LibrarySystemService.Book[] GetBookByName(string carname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookByName", ReplyAction="http://tempuri.org/IService1/GetBookByNameResponse")]
        System.Threading.Tasks.Task<LibrarySystemService.Book[]> GetBookByNameAsync(string carname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        string AddStudent(int id, string Name, string Email, string Address, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task<string> AddStudentAsync(int id, string Name, string Email, string Address, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        string AddBook(int id, string Name, int price, int ISBN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(int id, string Name, int price, int ISBN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudentBook", ReplyAction="http://tempuri.org/IService1/AddStudentBookResponse")]
        string AddStudentBook(LibrarySystemService.StudentBook uc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudentBook", ReplyAction="http://tempuri.org/IService1/AddStudentBookResponse")]
        System.Threading.Tasks.Task<string> AddStudentBookAsync(LibrarySystemService.StudentBook uc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentBooks", ReplyAction="http://tempuri.org/IService1/GetStudentBooksResponse")]
        LibrarySystemService.StudentBook[] GetStudentBooks(int uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentBooks", ReplyAction="http://tempuri.org/IService1/GetStudentBooksResponse")]
        System.Threading.Tasks.Task<LibrarySystemService.StudentBook[]> GetStudentBooksAsync(int uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentBook", ReplyAction="http://tempuri.org/IService1/GetStudentBookResponse")]
        LibrarySystemService.StudentBook GetStudentBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentBook", ReplyAction="http://tempuri.org/IService1/GetStudentBookResponse")]
        System.Threading.Tasks.Task<LibrarySystemService.StudentBook> GetStudentBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudentBook", ReplyAction="http://tempuri.org/IService1/UpdateStudentBookResponse")]
        string UpdateStudentBook(LibrarySystemService.StudentBook uc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudentBook", ReplyAction="http://tempuri.org/IService1/UpdateStudentBookResponse")]
        System.Threading.Tasks.Task<string> UpdateStudentBookAsync(LibrarySystemService.StudentBook uc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudentBook", ReplyAction="http://tempuri.org/IService1/DeleteStudentBookResponse")]
        string DeleteStudentBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudentBook", ReplyAction="http://tempuri.org/IService1/DeleteStudentBookResponse")]
        System.Threading.Tasks.Task<string> DeleteStudentBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        string DeleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        System.Threading.Tasks.Task<string> DeleteBookAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LibAppHost.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LibAppHost.ServiceReference1.IService1>, LibAppHost.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LibrarySystemService.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<LibrarySystemService.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public LibrarySystemService.Book[] GetBook(int id) {
            return base.Channel.GetBook(id);
        }
        
        public System.Threading.Tasks.Task<LibrarySystemService.Book[]> GetBookAsync(int id) {
            return base.Channel.GetBookAsync(id);
        }
        
        public LibrarySystemService.Book[] GetBookByName(string carname) {
            return base.Channel.GetBookByName(carname);
        }
        
        public System.Threading.Tasks.Task<LibrarySystemService.Book[]> GetBookByNameAsync(string carname) {
            return base.Channel.GetBookByNameAsync(carname);
        }
        
        public string AddStudent(int id, string Name, string Email, string Address, string Password) {
            return base.Channel.AddStudent(id, Name, Email, Address, Password);
        }
        
        public System.Threading.Tasks.Task<string> AddStudentAsync(int id, string Name, string Email, string Address, string Password) {
            return base.Channel.AddStudentAsync(id, Name, Email, Address, Password);
        }
        
        public string AddBook(int id, string Name, int price, int ISBN) {
            return base.Channel.AddBook(id, Name, price, ISBN);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(int id, string Name, int price, int ISBN) {
            return base.Channel.AddBookAsync(id, Name, price, ISBN);
        }
        
        public string AddStudentBook(LibrarySystemService.StudentBook uc) {
            return base.Channel.AddStudentBook(uc);
        }
        
        public System.Threading.Tasks.Task<string> AddStudentBookAsync(LibrarySystemService.StudentBook uc) {
            return base.Channel.AddStudentBookAsync(uc);
        }
        
        public LibrarySystemService.StudentBook[] GetStudentBooks(int uid) {
            return base.Channel.GetStudentBooks(uid);
        }
        
        public System.Threading.Tasks.Task<LibrarySystemService.StudentBook[]> GetStudentBooksAsync(int uid) {
            return base.Channel.GetStudentBooksAsync(uid);
        }
        
        public LibrarySystemService.StudentBook GetStudentBook(int id) {
            return base.Channel.GetStudentBook(id);
        }
        
        public System.Threading.Tasks.Task<LibrarySystemService.StudentBook> GetStudentBookAsync(int id) {
            return base.Channel.GetStudentBookAsync(id);
        }
        
        public string UpdateStudentBook(LibrarySystemService.StudentBook uc) {
            return base.Channel.UpdateStudentBook(uc);
        }
        
        public System.Threading.Tasks.Task<string> UpdateStudentBookAsync(LibrarySystemService.StudentBook uc) {
            return base.Channel.UpdateStudentBookAsync(uc);
        }
        
        public string DeleteStudentBook(int id) {
            return base.Channel.DeleteStudentBook(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteStudentBookAsync(int id) {
            return base.Channel.DeleteStudentBookAsync(id);
        }
        
        public string DeleteBook(int id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBookAsync(int id) {
            return base.Channel.DeleteBookAsync(id);
        }
    }
}
