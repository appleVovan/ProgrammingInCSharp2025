using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Repositories;
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
        private static FileRepository Storage = new FileRepository();

        public async Task<User> Authenticate(UserCandidate userCandidate)
        {
            if (String.IsNullOrWhiteSpace(userCandidate.Login) || String.IsNullOrWhiteSpace(userCandidate.Password))
                throw new ArgumentException("Login or Password is empty!");
            DBUser dBUser = await Storage.GetAsync(userCandidate.Login);
                        
            if (dBUser == null || dBUser.Login != userCandidate.Login || dBUser.Password != userCandidate.Password)
                throw new AuthenticationException("Wrong login or password!");

            return new User(dBUser.Guid, dBUser.Login, dBUser.FirstName, dBUser.LastName);
        }

        public async Task RegisterUser(RegistrationUser registrationUser)
        {
            if (String.IsNullOrWhiteSpace(registrationUser.Login) || String.IsNullOrWhiteSpace(registrationUser.Password) || String.IsNullOrWhiteSpace(registrationUser.FirstName) || String.IsNullOrWhiteSpace(registrationUser.LastName))
                throw new ArgumentException("First Name, Last Name, Login or Password is empty!");

            DBUser dbUser = await Storage.GetAsync(registrationUser.Login);

            if (dbUser != null)
                throw new Exception("User with this login already exists!");

            dbUser = new DBUser(registrationUser.Login, registrationUser.Password, registrationUser.FirstName, registrationUser.LastName);

            await Storage.AddOrUpdateAsync(dbUser);
        }
    }
}
