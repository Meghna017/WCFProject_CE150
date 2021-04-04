using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class StudentViewModels
    {
        public int StudentId { get; set; }

        public String Name { get; set; }

        public String CourseName { get; set; }

        public String Contact { get; set; }
    }
}