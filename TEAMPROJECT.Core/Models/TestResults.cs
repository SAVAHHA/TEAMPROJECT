﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAMPROJECT.Core.Models
{
    public class TestResults
    {   public string TestName { get; set; }
        public string ResultName { get; set; }
        public User User { get; set; }
        public DateTime PassDate { get; set; }

        //public TestResults(string name, string resN, User user, DateTime pass)
        //{
        //    TestName = name;
        //    ResultName = resN;
        //    User = user;
        //    PassDate = pass;
        //}

    }
}
