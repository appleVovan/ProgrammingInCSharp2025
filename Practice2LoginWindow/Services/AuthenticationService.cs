using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Services
{
    internal class AuthenticationService
    {
        private static List<DBUser> Storage = new List<DBUser>();

        public User Authenticate(UserCandidate userCandidate)
        {
            if (String.IsNullOrWhiteSpace(userCandidate.Login) || String.IsNullOrWhiteSpace(userCandidate.Password))
                throw new ArgumentException("Login or Password is empty!");
            DBUser dBUser = Storage.FirstOrDefault(user => user.Login == userCandidate.Login && user.Password == userCandidate.Password);
            
            if (dBUser == null)
                throw new AuthenticationException("Wrong login or password!");

            return new User(dBUser.Guid, dBUser.Login, dBUser.FirstName, dBUser.LastName);
        }
    }
}
