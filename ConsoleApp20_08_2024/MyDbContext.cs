using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WpfApp2.ConsoleApp20_08_2024.Enities;


namespace WpfApp2.ConsoleApp20_08_2024
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.LibrarianConfiguration();
            //modelBuilder.BookConfiguration();
        }
    }
}
