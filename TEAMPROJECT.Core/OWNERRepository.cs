using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEAMPROJECT.Core.Models;

namespace TEAMPROJECT.Core
{
    public class OWNERRepository
    {
        Repository _repo = new Repository();
        TESTYRepository _testRepo = new TESTYRepository();
        public DateTime? selectedDate = new DateTime();
        public AllTests selectedTest;
        public List<ResultsCount> results = new List<ResultsCount>();
        public List<ResultsCount> neededResults = new List<ResultsCount>();
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

        public int CountPassesOneDay()
        {
            if (selectedDate.ToString() == "")
            {
                int count = 0;
                foreach (var pass in _testRepo.testResults)
                {
                    if (pass.TestName == selectedTest.TestName)
                    {
                        count += 1;
                    }
                }
                return count;
            }
            else
            {
                int count = 0;
                foreach (var pass in _testRepo.testResults)
                {
                    if (pass.TestName == selectedTest.TestName && selectedDate.ToString().Substring(0, 10) == pass.PassDate.ToString().Substring(0, 10))
                    {
                        count += 1;
                    }
                }
                return count;
            }
        }

        public void CountingResults()
        {
            foreach (var pass in _testRepo.testResults)
            {
                bool found = false;
                foreach (var item in results)
                {
                    if (item.TestName == pass.TestName && item.ResulttName == pass.ResultName)
                    {
                        item.ResultNumber += 1;
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    ResultsCount res = new ResultsCount();
                    res.TestName = pass.TestName;
                    res.ResulttName = pass.ResultName;
                    res.ResultNumber = 1;
                    res.DateTiming = pass.PassDate;
                    results.Add(res);
                }
            }
        }

        public void ChoosingNeededResults()
        {
            foreach (var res in results)
            {
                if (selectedDate.ToString() == "")
                {
                    if (res.TestName == selectedTest.TestName)
                    {
                        neededResults.Add(res);
                    }
                }
                else
                {
                    if (res.TestName == selectedTest.TestName && selectedDate.ToString().Substring(0, 10) == res.DateTiming.ToString().Substring(0, 10))
                    {
                        neededResults.Add(res);
                    }
                }
            }
        }
    }
}
