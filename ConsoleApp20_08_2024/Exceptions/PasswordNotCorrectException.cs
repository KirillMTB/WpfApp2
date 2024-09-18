using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ConsoleApp20_08_2024.Exceptions
{
    public class PasswordNotCorrectException : Exception
    {
        public PasswordNotCorrectException(string message) : base(message) { }
    }
}
