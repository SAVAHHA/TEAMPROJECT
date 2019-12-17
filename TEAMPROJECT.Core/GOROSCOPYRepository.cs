using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
using TEAMPROJECT.Core.Models;
using TEAMPROJECT.Core.Interfaces;

namespace TEAMPROJECT.Core
{
    class GOROSCOPYRepository: Repository
    {
        new List<User> Users = new List<User>();
        List<Zodiac> Zodiacs = new List<Zodiac>();
        List<Prediction> Predictions = new List<Prediction>();

        public int GetUserID_by_Login(string login, string password)
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

        public void AddUser(string name, DateTime dateOfBirth, string login, string password)
        {
            User user = new User();
            user.Name = name;
            user.DateOfBirth = dateOfBirth;
            user.Login = login;
            user.Password = password;
            user.UserID = Users.Count() + 1;
            Users.Add(user);
        }
    }
}
