using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;

namespace TEAMPROJECT.Core
{
    class GOROSCOPYRepository: IRepository
    {
        //Регулярное вырожение для двух проектов
        private Regex regex = new Regex(@"\\TEAMPROJECT\.GUI\.User\\bin\\Debug|\\TEAMPROJECT\.GUI\.Owner\\bin\\Debug");
        public List<User> Users = new List<User>();
        
        public virtual T Deserialize<T>(string fileName) {
            using(var sr = new StreamReader(fileName)) {
                using(var jsonReader = new JsonTextReader(sr)) 
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

         
    }
}
