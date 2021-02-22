using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace LibrarySystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        List<Book> GetBook(int id);

        [OperationContract]
        List<Book> GetBookByName(string carname);
        
        [OperationContract]
        string AddStudent(int id,string Name, string Email, string Address, string Password);
        [OperationContract]
        string AddBook(int id, string Name, int price,int ISBN);

        [OperationContract]
        string AddStudentBook(StudentBook uc);

        [OperationContract]
        List<StudentBook> GetStudentBooks(int uid);

        [OperationContract]
        StudentBook GetStudentBook(int id);

        [OperationContract]
        string UpdateStudentBook(StudentBook uc);

        [OperationContract]
        string DeleteStudentBook(int id);
        
        [OperationContract]
        string DeleteBook(int id);

    }


}
