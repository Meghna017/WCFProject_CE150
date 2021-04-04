using LibraryManagement.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace LibraryManagement.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {

        }

    
        public DbSet<Student> Student { get; set; }
        public DbSet<Book> Book { get; set; }



    }
}