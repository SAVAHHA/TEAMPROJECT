using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAMPROJECT.Core
{
    public class OWNERRepository
    {
        Repository _repo = new Repository();
        public DateTime? selectedDate = new DateTime();
        public int CountZodiac(string zodiacName)
        {
            int count = 0;
            foreach (var user in _repo.Users)
            {
                if (user.Zodiac.Name == zodiacName)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
