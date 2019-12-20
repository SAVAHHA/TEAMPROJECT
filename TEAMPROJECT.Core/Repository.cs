using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEAMPROJECT.Core.Interfaces;
using System.Text.RegularExpressions;
using System.IO;
using TEAMPROJECT.Core.Models;
using Newtonsoft.Json;

namespace TEAMPROJECT.Core
{
    public class Repository: IRepository
    {
        //Регулярное вырожение для двух проектов
        //public Regex regex = new Regex(@"\\TEAMPROJECT\.GUI\.User\\bin\\Debug|\\TEAMPROJECT\.GUI\.Owner\\bin\\Debug");
        public List<User> Users = new List<User>();
        public List<Zodiac> Zodiacs = new List<Zodiac>();
        
        public void LoadData()
        {
            //Users = Deserialize<List<User>>("Users.json");
            //Zodiacs = Deserialize<List<Zodiac>>("Zodiacs.json");
        }

        public virtual T Deserialize<T>(string fileName)
        {
            using (var sw = new StreamReader(fileName))
            {
                using (var jsonReader = new JsonTextReader(sw))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<T>(jsonReader);
                }
            }
        }
        public virtual void Serialize<T>(string fileName, T data)
        {
            using (var sw = new StreamWriter(fileName))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, data);
                }
            }
        }
        public virtual void AddUser(string name, DateTime dateOfBirth, string login, string password)
        {
            User user = new User();
            user.Name = name;
            user.DateOfBirth = dateOfBirth;
            user.Login = login;
            user.Password = password;
            user.UserID = Users.Count() + 1;
            foreach (var zodiac in Zodiacs)
            {
                if (zodiac.FirstDate.Month <= dateOfBirth.Month && zodiac.FirstDate.Day <= dateOfBirth.Day && zodiac.LastDate.Month >= dateOfBirth.Month && zodiac.LastDate.Day >= dateOfBirth.Day) 
                {
                    user.Zodiac = zodiac;
                }
            }
            Users.Add(user);
        }
        public virtual bool Entrance(string login, string password)
        {
            bool check = false;
            foreach (var user in Users)
            {
                if (user.Login == login && user.Password == password)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public virtual int GetID(string login, string password)
        {
            int Id = 0;
            foreach (var user in Users)
            {
                if (user.Login == login && user.Password == password)
                {
                    Id = user.UserID;
                }
            }
            return Id;
        }
    }
}
