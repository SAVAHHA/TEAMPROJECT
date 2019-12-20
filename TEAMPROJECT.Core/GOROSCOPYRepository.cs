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
        public List<PredictionsPerZodiacs> predictionsPerZodiacs = new List<PredictionsPerZodiacs>();

        public GOROSCOPYRepository()
        {
            LoadGOROSCOPYData();
        }
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
        public string GetPrediction(string zodiac)
        {
            predictionsPerZodiacs = repository.Deserialize<List<PredictionsPerZodiacs>>("../../TEAMPROJECT.Core/Data/PredictionsPerZodiacs.json");
            string? prediction = null;
            bool check = false;
            foreach (var predictionPZ in predictionsPerZodiacs)
            {
                if (predictionPZ.Zodiac.Name == zodiac && predictionPZ.DateOfPrediction.Date == DateTime.Now.Date)
                {
                    prediction = predictionPZ.Prediction.Info;
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                Random random = new Random();
                int number = random.Next(Predictions.Count());
                prediction = Predictions[number].Info;
                PredictionsPerZodiacs newPredictionPerZodiac = new PredictionsPerZodiacs();
                newPredictionPerZodiac.Prediction = Predictions[number];
                newPredictionPerZodiac.DateOfPrediction = DateTime.Now;
                foreach (var currentZodiac in repository.Zodiacs)
                {
                    if (currentZodiac.Name == zodiac)
                    {
                        newPredictionPerZodiac.Zodiac = currentZodiac;
                        break;
                    }
                }
                predictionsPerZodiacs.Add(newPredictionPerZodiac);
                repository.Serialize<List<PredictionsPerZodiacs>>("../../TEAMPROJECT.Core/Data/PredictionsPerZodiacs.json", predictionsPerZodiacs);

            }
            return prediction;
        }
        
        public List<Compability> GetCompability(string zodiac)
        {
            var CurrentCompability = new List<Compability>();
            foreach (var compability in Compabilities)
            {
                if (compability.Zodiac1 == zodiac)
                {
                    CurrentCompability.Add(compability);
                }
            }
            return CurrentCompability;
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
            repository.Serialize("../../TEAMPROJECT.Core/Data/Predictions.json", Predictions);
        }
    }
}
