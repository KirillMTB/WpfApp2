﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ConsoleApp20_08_2024.Enities;

namespace WpfApp2.ConsoleApp20_08_2024.Abstract
{
    public interface ILibrarianRepository
    {
        Librarian LoginLibrarianByEmailAndPassword(string email, string password);
        bool CreateLibrarian(Librarian librarian);
    }
}
