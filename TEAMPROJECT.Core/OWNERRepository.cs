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
                foreach (var item in _testRepo.testResults)
                {
                    if (item.User.Login == user.Login)
                    {
                        counter += 1;
                        break;
                    }
                }
            }
            return counter;
        }

        public void PassesCounter()
        {
            foreach (var item in _testRepo.allTests)
            {
                int counter = 0;
                foreach (var pass in _testRepo.testResults)
                {
                    if (item.TestName == pass.TestName)
                    {
                        counter += 1;
                    }
                }
                item.NumnerOfPasses = counter;
            }
        }

        public string GetMax()
        {
            int max = _testRepo.allTests[0].NumnerOfPasses;
            string name = _testRepo.allTests[0].TestName;
            foreach (var item in _testRepo.allTests)
            {
                if (item.NumnerOfPasses > max)
                {
                    max = item.NumnerOfPasses;
                    name = item.TestName;
                }
            }
            return name;
        }

        public string GetMin()
        {
            int min = _testRepo.allTests[0].NumnerOfPasses;
            string name = _testRepo.allTests[0].TestName;
            foreach (var item in _testRepo.allTests)
            {
                if (item.NumnerOfPasses < min)
                {
                    min = item.NumnerOfPasses;
                    name = item.TestName;
                }
            }
            return name;
        }
    }
}
