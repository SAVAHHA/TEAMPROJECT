using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
using TEAMPROJECT.Core.Models;
using TEAMPROJECT.Core.Interfaces;

namespace TEAMPROJECT.Core
{
    class GOROSCOPYRepository: Repository
    {
        new List<User> Users = new List<User>();
        List<Zodiac> Zodiacs = new List<Zodiac>();
        List<Prediction> Predictions = new List<Prediction>();


    }
}
