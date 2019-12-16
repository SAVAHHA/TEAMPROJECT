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
    }
}
