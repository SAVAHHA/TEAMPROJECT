using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAMPROJECT.Core
{
    public class OWNERRepository
    {
        Repository _repo = new Repository();
        TESTYRepository _testRepo = new TESTYRepository();
        public DateTime? selectedDate = new DateTime();
        public int CountZodiac(string zodiacName)
        {
            int count = 0;
            foreach (var user in _repo.Users)
            {
                if (user.Zodiac.Name == zodiacName)
                {
                    count += 1;
                }
            }
            return count;
        }
        public int CountUsersUsingTests()
        {
            int counter = 0;
            foreach (var user in _repo.Users)
            {
                Console.WriteLine(user.Name);
                foreach (var item in _testRepo.testResults)
                {
                    Console.WriteLine(item.User.Name);
                    Console.WriteLine(counter);
                    if (item.User.Login == user.Login)
                    {
                        counter += 1;
                        break;
                    }
                }
            }
            return counter;
        }
    }
}
