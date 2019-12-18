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
    }
}
