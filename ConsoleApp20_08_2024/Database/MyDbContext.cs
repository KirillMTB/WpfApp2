using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WpfApp2.ConsoleApp20_08_2024.Enities;


namespace WpfApp2.ConsoleApp20_08_2024
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyDbContext() : base()
        {
            Database.EnsureDeleted(); //если БД есть, о она удалится, если нет, то создаться заново
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn1 = "Server=(localdb)\\mssqllocaldb;Database=WpfApp2Database;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(conn1);
        }

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
        }
    }
}
