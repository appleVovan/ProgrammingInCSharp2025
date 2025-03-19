using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models
{
    internal class User
    {
        public Guid Guid { get; }
        public string Login { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public User(Guid guid, string login, string firstName, string lastName)
        {
            Guid = guid;
            Login = login;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
