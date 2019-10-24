using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NpgsqlProject.Models
{
    public class BooksContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksContext(DbContextOptions<BooksContext> options)
           : base(options)
        {
           // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=BookStore;Username=postgres;Password=1");
        }
    }
}

