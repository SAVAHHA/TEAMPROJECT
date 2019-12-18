using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;
using TEAMPROJECT.Core;
using TEAMPROJECT.Core.Models;
using TEAMPROJECT.Core.Interfaces;

namespace TEAMPROJECT.Core
{
    public class TESTYRepository
    {
        public List<Test> winxtest;
        public List<TestResults> testResults;
        //Users берем из Repository
        private void LoadData()
        {
            string fileName =
            var winxtest = Repository.Deserialize<List<Test>>("WinxTest");
            //var data = Deserialize<ParkingData>(ParkingDataFileName);
            //users = Deserialize<List<User>>(UsersFileName);

            //testResults = Deserialize<List<TestResults>>(regex.Replace(Environment.CurrentDirectory, "") + ));
            //parkingCapacity = data.Capacity;
            //pastSessions = data.PastSessions ?? new List<ParkingSession>();
            //activeSessions = data.ActiveSessions ?? new List<ParkingSession>();

        }
    }
}
