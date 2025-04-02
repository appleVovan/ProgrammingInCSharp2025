using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Repositories
{
    internal class FileRepository
    {
        private static readonly string BaseFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"CSKMAStorage2025");

        public FileRepository()
        {
            if (!Directory.Exists(BaseFolder)) 
                Directory.CreateDirectory(BaseFolder);
        }

        public async Task AddOrUpdateAsync(DBUser obj)
        {
            string jsonObj = JsonSerializer.Serialize(obj);

            using (StreamWriter sw = new StreamWriter(Path.Combine(BaseFolder, obj.Login), false))
            {
                await sw.WriteAsync(jsonObj);
            }
        }

        public async Task<DBUser> GetAsync(string login)
        {
            string filePath = Path.Combine(BaseFolder, login);
            if (!File.Exists(filePath))
                return null;
            string jsonObj;
            using (StreamReader sr = new StreamReader(filePath))
            {
                jsonObj = await sr.ReadToEndAsync();
            }

            return JsonSerializer.Deserialize<DBUser>(jsonObj);
        }

        public List<DBUser> GetAll()
        {
            var res = new List<DBUser>();

            foreach (var file in Directory.EnumerateFiles(BaseFolder))
            {
                string jsonObj;
                using (StreamReader sr = new StreamReader(file))
                {
                    jsonObj = sr.ReadToEnd();
                }

                res.Add(JsonSerializer.Deserialize<DBUser>(jsonObj));
            }

            return res;
        }
    }
}
