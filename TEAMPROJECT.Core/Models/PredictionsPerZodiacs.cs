using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAMPROJECT.Core.Models
{
    public class PredictionsPerZodiacs
    {
        public Prediction Prediction { get; set; }
        public Zodiac Zodiac { get; set; }
        public DateTime DateOfPrediction { get; set; }
    }
}
