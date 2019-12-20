using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;
using TEAMPROJECT.Core.Models;
using TEAMPROJECT.Core.Interfaces;

namespace TEAMPROJECT.Core
{
    public class TESTYRepository
    {

        public TESTYRepository()
        {
            LoadData();

        }
        
        Repository repository = new Repository();
        public List<Test> winxtest;
        public List<TestResults> testResults;
        public List<AllTests> allTests;
        public const string AllTestsName = "../../../Data/AllTests.json";
        //public const string TestResultsName = "../../../Data/.json";
        public const string WinxTestName = "../../Data/WinxTest.json";
        //Users берем из Repository
        private void LoadData()
        {

            //allTests = repository.Deserialize<List<AllTests>>(AllTestsName);
            winxtest = repository.Deserialize<List<Test>>(WinxTestName);
            //testResults = repository.Deserialize<List<TestResults>>(TestResultsName);   
        }
        public void ButtonTestLogic(List<Test> testlist, int clickcount, int answernumber, int r1, int r2, int r3, int r4, int r5, int r6)
        {
            foreach (Test answer in testlist)
            {
                //string writenextquestion = winxanswer.Question;
                if (answer.QuestionId - 1 == clickcount && answer.AnswerId == answernumber)
                {
                    r1 += answer.Result1;
                    r2 += answer.Result2;
                    r3 += answer.Result3;
                    r4 += answer.Result4;
                    r5 += answer.Result5;
                    r6 += answer.Result6;
                }
            }        
        }

        public string TextQATest(List<Test> testlist, int clickcount)
        {
            string questionText = " ";
            foreach (Test answer in testlist)
            {
                
                    if (answer.QuestionId == clickcount + 1)
                    {
                        questionText = answer.Question;


                    }
            }
            return questionText;
        }
        public string TextA1Test(List<Test> testlist, int clickcount)
        {
            string answer1Text = " ";
            foreach (Test answer in testlist)
            {
                if (answer.QuestionId == clickcount + 1 && answer.AnswerId == 1)
                {
                    answer1Text = answer.Question;
                }
            }
            return answer1Text;
        }
        public string TextA2Test(List<Test> testlist, int clickcount)
        {
            string answer2Text = " ";
            foreach (Test answer in testlist)
            {
                if (answer.QuestionId == clickcount + 1 && answer.AnswerId == 2)
                {
                    answer2Text = answer.Question;
                }
            }
            return answer2Text;
        }
        public string TextA3Test(List<Test> testlist, int clickcount)
        {
            string answer3Text = " ";
            foreach (Test answer in testlist)
            {
                if (answer.QuestionId == clickcount + 1 && answer.AnswerId == 3)
                {
                    answer3Text = answer.Question;
                }
            }
            return answer3Text;
        }
        public string TextA4Test(List<Test> testlist, int clickcount)
        {
            string answer4Text = " ";
            foreach (Test answer in testlist)
            {
                if (answer.QuestionId == clickcount + 1 && answer.AnswerId == 4)
                {
                    answer4Text = answer.Question;
                }
            }
            return answer4Text;
        }

        public int GetMax(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            int n1n2 = Math.Max(n1, n2);
            int n3n4 = Math.Max(n3, n4);
            int n5n6 = Math.Max(n5, n6);
            int n1n2n3n4 = Math.Max(n1n2, n3n4);
            return Math.Max(n1n2n3n4, n5n6);
        }
        public int TestResultLogic(int r1, int r2, int r3, int r4, int r5, int r6)
        {
            return GetMax(r1, r2, r3, r4, r5, r6);
        }


    }
}
