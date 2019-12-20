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
        //Zodiacs берем из Repository
        public List<Prediction> Predictions = new List<Prediction>();
        public List<Compability> Compabilities = new List<Compability>();
        public Repository repository = new Repository();

        public void LoadGOROSCOPYData()
        {
            Predictions = repository.Deserialize<List<Prediction>>("../../TEAMPROJECT.Core/Data/Predictions.json");
            Compabilities = repository.Deserialize<List<Compability>>("../../TEAMPROJECT.Core/Data/Compabilities.json");
        }
        public string GetRandomPrediction()
        {
            Random random = new Random();
            int number = random.Next(Predictions.Count());
            string predictionText = Predictions[number].Info;
            return predictionText;
        }
        public int GetCompability(string zodiac1, string zodiac2)
        {
            int percent = 0;
            foreach (var compability in Compabilities)
            {
                if (compability.Zodiac1.Name == zodiac1 && compability.Zodiac2.Name == zodiac2)
                {
                    percent = compability.Percents;
                }
            }
            return percent;
        }
        public void AddPrediction(string predictionText)
        {
            Prediction prediction = new Prediction();
            prediction.Info = predictionText;
            prediction.PredictionID = Predictions.Count() + 1;
            Predictions.Add(prediction);
        }
        public void RewritePredictions()
        {
            repository.Serialize("Predictions", Predictions);
        }
    }
}
