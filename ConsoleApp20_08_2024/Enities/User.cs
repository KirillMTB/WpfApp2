﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ConsoleApp20_08_2024.Enities
{
    [Table("MainUser")]
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public Book? Book { get; set; }
    }

    public class UserAdmin
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
