﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace WpfApp2.ConsoleApp20_08_2024.Enities
{
    public class Librarian : PeopleInfo
    {
        public DateTime StartWorkDate { get; set; }
    }

    public static class LibrarianExtention
    {
        public static void LibrarianConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Librarian>().HasKey(x => x.Id);
            modelBuilder.Entity<Librarian>().Property(x => x.LastName).HasMaxLength(128);
            modelBuilder.Entity<Librarian>().Property(x => x.FirstName).HasMaxLength(128);
            modelBuilder.Entity<Librarian>().Property(x => x.Patronymic).HasMaxLength(128).IsRequired(false);
            modelBuilder.Entity<Librarian>().Property(x => x.Email).HasMaxLength(128);
            modelBuilder.Entity<Librarian>().Property(x => x.Password).HasMaxLength(128);

            //var librarians = new Librarian[]
            //{
            //    new Librarian() {
            //        Id = 1,
            //        LastName = "Филатов",
            //        FirstName = "Владислав",
            //        Patronymic = "Алексеевич",
            //        Email = "filatov@gmail.com",
            //        Password = "123456",
            //        BirthDay = new DateTime(1999, 6, 23),
            //        StartWorkDate = new DateTime(2023, 6, 1)
            //    }
            //};
            modelBuilder.Entity<Librarian>().HasData(new Librarian()
            {
                Id = 1,
                LastName = "Филатов",
                FirstName = "Владислав",
                Patronymic = "Алексеевич",
                Email = "filatov@gmail.com",
                Password = "123456",
                BirthDay = new DateTime(1999, 6, 23),
                StartWorkDate = new DateTime(2023, 6, 1)
            });
            
        }
    }

}
