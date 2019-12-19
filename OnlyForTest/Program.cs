using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEAMPROJECT.Core;

namespace OnlyForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            repository.AddUser("Sam", "12.07.1900", "uu", "uu");
            repository.Serialize<List<TEAMPROJECT.Core.Models.User>>("Users.json", repository.Users);
            Console.WriteLine("y");
        }
    }
}
