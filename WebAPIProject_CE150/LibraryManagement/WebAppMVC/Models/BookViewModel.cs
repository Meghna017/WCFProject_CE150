using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class BookViewModel
    {
        private int bookId;

        public int GetBookId()
        {
            return bookId;
        }

        public void SetBookId(int value)
        {
            bookId = value;
        }

        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string CourseName { get; set; }

        public string BookName { get; set; }

        

    }
}