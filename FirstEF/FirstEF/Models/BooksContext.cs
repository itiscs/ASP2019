using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstEF.Models
{
    public class BooksContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }


        public BooksContext():base("DefaultConnection")
        {

        }


    }
}