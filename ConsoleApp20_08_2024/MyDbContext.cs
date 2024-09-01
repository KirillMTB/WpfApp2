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
        public DbSet<UserAdmin> Admins { get; set; }

        //public MyDbContext() : base()
        //{
        //    //Database.EnsureDeleted(); //если БД есть, о она удалится, если нет, то создаться заново

        //    //Database.EnsureCreated();

        //}

        public MyDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //if (!optionsBuilder.IsConfigured)
        //    //{
        //    //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        //    //}


        //    var builder = new ConfigurationBuilder();
        //    builder.SetBasePath(Directory.GetCurrentDirectory());
        //    builder.AddJsonFile("appsettings.json");
        //    var config = builder.Build();

        //    var conn1 = config.GetConnectionString("SqlServerConnection");
        //    optionsBuilder.UseSqlServer(conn1);

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User[] users = new User[]
            {
                new User() { Id = 1, Name = "Vlad", Email = "1@mail.ru", Password = "12345", BirthDay = DateTime.UtcNow},
                new User() { Id = 2, Name = "Alex", Email = "2@mail.ru", Password = "12345", BirthDay = DateTime.UtcNow},
                new User() { Id = 3, Name = "Kirill", Email = "3@mail.ru", Password = "12345", BirthDay = DateTime.UtcNow},
                new User() { Id = 4, Name = "Kostya", Email = "4@mail.ru", Password = "12345", BirthDay = DateTime.UtcNow},
                new User() { Id = 5, Name = "Klim", Email = "5@mail.ru", Password = "12345", BirthDay = DateTime.UtcNow}
            };
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.BookConfiguration();
        }
    }
}
