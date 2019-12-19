using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TEAMPROJECT.Core.Interfaces
{
    interface IRepository
    {
        
        //Прописать код для Json файлов
        T Deserialize<T>(string fileName);
        void Serialize<T>(string fileName, T data);
        void AddUser(string name, DateTime dateOfBirth, string login, string password);
        bool Entrance(string login, string password, out int id);
        int GetID(string login, string password);
    }
}
