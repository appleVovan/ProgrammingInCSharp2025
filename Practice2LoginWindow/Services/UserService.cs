using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Services
{
    class UserService
    {
        private static FileRepository Repository = new FileRepository();

        public async Task<List<User>> GetAllUsers()
        {
            var res = new List<User>();

            foreach (var dbUser in await Repository.GetAllAsync())
            {
                res.Add(new User(dbUser.Guid, dbUser.Login, dbUser.FirstName, dbUser.LastName));
            }
            return res;
        }
    }
}
