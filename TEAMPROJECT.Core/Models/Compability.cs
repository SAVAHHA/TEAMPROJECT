using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAMPROJECT.Core.Models
{
    public class Compability
    {
        public int CompabilityID { get; set; }
        public Zodiac Zodiac1 { get; set; }
        public Zodiac Zodiac2 { get; set; }
        public int Percents { get; set; }
    }
}
