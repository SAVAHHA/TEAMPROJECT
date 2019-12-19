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
        //Users берем из Repository
        private void LoadData()
        {
            winxtest = repository.Deserialize<List<Test>>("WinxTest");
            testResults = repository.Deserialize<List<TestResults>>("TestResults");   
        }
        private void ButtonTestLogic(int clickcount, int answernumber, int r1, int r2, int r3, int r4, int r5, int r6)
        {
            foreach (Test winxanswer in winxtest)
            {
                //string writenextquestion = winxanswer.Question;
                if (winxanswer.QuestionId == clickcount && winxanswer.AnswerId == answernumber)
                {
                    r1 += winxanswer.Result1;
                    r2 += winxanswer.Result2;
                    r3 += winxanswer.Result3;
                    r4 += winxanswer.Result4;
                    r5 += winxanswer.Result5;
                    r6 += winxanswer.Result6;
                }
            }        
        }

        private int GetMax(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            int n1n2 = Math.Max(n1, n2);
            int n3n4 = Math.Max(n3, n4);
            int n5n6 = Math.Max(n5, n6);
            int n1n2n3n4 = Math.Max(n1n2, n3n4);
            return Math.Max(n1n2n3n4, n5n6);
        }
        private int TestResultLogic(int r1, int r2, int r3, int r4, int r5, int r6)
        {
            return GetMax(r1, r2, r3, r4, r5, r6);
        }
    }
}
