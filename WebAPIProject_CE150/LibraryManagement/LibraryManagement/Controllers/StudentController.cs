using LibraryManagement.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryManagement.Controllers
{
    public class StudentController : ApiController
    {
        DatabaseContext db = new DatabaseContext();

        //api/student
        public IEnumerable<Student> GetStudents()
        {
            return db.Student.ToList();
        }

        //api/student/288
        public Student GetStudent(int id)
        {
            return db.Student.Find(id);
        }

        //api/student
        [HttpPost]
        public HttpResponseMessage AddStudent(Student model)
        {
            try
            {
                db.Student.Add(model);
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

        public HttpResponseMessage UpdateStudent(int id, Student model)
        {
            try
            {
                if (id == model.StudentId)
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
        public HttpResponseMessage DeleteStudent(int id)
        {
            Student Student = db.Student.Find(id);
            if (Student != null)
            {
                db.Student.Remove(Student);
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

