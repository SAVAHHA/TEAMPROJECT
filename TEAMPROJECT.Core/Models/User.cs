﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAMPROJECT.Core.Models
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Zodiac Zodiac { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }
    }
}
