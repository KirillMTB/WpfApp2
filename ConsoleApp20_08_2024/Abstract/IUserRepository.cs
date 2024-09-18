using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ConsoleApp20_08_2024.Enities;

namespace WpfApp2.ConsoleApp20_08_2024.Abstract
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User GetUserByLastName(int lastName);
        User GetUserByFullName(int fullName);
        bool CreateUser(User user);
    }
}
