using LibraryManagement.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryManagement.Controllers
{
    public class BookController : ApiController
    {
        DatabaseContext db = new DatabaseContext();
        
        //api/book
        public IEnumerable<Book> GetBooks()
        {
            return db.Book.ToList();
        }

        //api/book/288
        public Book GetBook(int StudentId)
        {
            return db.Book.Find(StudentId);
        }

        //api/Book
        [HttpPost]
        public HttpResponseMessage AddBook(Book model)
        {
            try
            {
                db.Book.Add(model);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;

            }
        }

        [HttpPut]

        public HttpResponseMessage UpdateBook(int Studentid, Book model)
        {
            try
            {
                if (Studentid == model.StudentId)
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
                }
            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
        }
        //api/student
        public HttpResponseMessage DeleteBook(int StudentId)
        {
            Student Student = db.Student.Find(StudentId);
            if (Student != null)
            {
                Student student1 = db.Student.Remove(Student);
                Student student = student1;
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            else
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
        }
    }
}
