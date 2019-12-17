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
    public class GOROSCOPYRepository
    {
        //Users берем из Repository
        List<Zodiac> Zodiacs = new List<Zodiac>();
        List<Prediction> Predictions = new List<Prediction>();

        public string GetRandomPrediction()
        {
            Random random = new Random();
            int number = random.Next(Predictions.Count());
            string predictionText = Predictions[number].Info;
            return predictionText;
        }

        
    }
}
