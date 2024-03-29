﻿using System;
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
        public Regex regex = new Regex(@"\\TEAMPROJECT\.GUI\.UserTestHoroscop\\bin|\\TEAMPROJECT\.GUI\.Owner\\bin");
        public List<User> Users = new List<User>();
        public List<Zodiac> Zodiacs = new List<Zodiac>();

        public Repository()
        {
            LoadData();
        }
        public void LoadData()
        {
            Zodiacs = Deserialize<List<Zodiac>>("../../TEAMPROJECT.Core/Data/Zodiacs.json");
            Users = Deserialize<List<User>>("../../TEAMPROJECT.Core/Data/Users.json");
        }

        public virtual T Deserialize<T>(string fileName)
        {
            using (var sw = new StreamReader(regex.Replace(Environment.CurrentDirectory, "") + fileName))
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
            using (var sw = new StreamWriter(regex.Replace(Environment.CurrentDirectory, "") + fileName))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, data);
                }
            }
        }
        public virtual void AddUser(string name, string dateOfBirthStr, string login, string password)
        {
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthStr);
            User user = new User();
            user.Name = name;
            user.DateOfBirth = dateOfBirth;
            user.Login = login;
            user.Password = password;
            user.UserID = Users.Count() + 1;
            foreach (var zodiac in Zodiacs)
            {
                if (zodiac.FirstDate.DayOfYear <= dateOfBirth.DayOfYear && zodiac.LastDate.DayOfYear >= dateOfBirth.DayOfYear)
                {
                    user.Zodiac = zodiac;
                }
            }
            Users.Add(user);
            Serialize<List<User>>("../../TEAMPROJECT.Core/Data/Users.json", Users);
        }
        public virtual bool Entrance(string login, string password, out User CurrentUser)
        {
            var CurrentUserCheck = new User();
            bool check = false;
            foreach (var user in Users)
            {
                if (user.Login == login && user.Password == password)
                {
                    check = true;
                    CurrentUserCheck = user;
                    break;
                }
            }
            CurrentUser = CurrentUserCheck;
            return check;
        }
        public bool CheckLogin(string login)
        {
            bool check = true;
            foreach (var user in Users)
            {
                if (user.Login == login)
                {
                    check = false;
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
