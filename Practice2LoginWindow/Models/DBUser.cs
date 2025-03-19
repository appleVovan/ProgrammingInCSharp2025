using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models
{
    internal class DBUser
    {
        public Guid Guid { get; }
        public string Login { get; }
        public string Password { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public DBUser(string login, string password, string firstName, string lastName)
        {
            Guid = Guid.NewGuid();
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
