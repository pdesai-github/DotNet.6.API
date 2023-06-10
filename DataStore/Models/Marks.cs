using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Models
{
    public class Marks
    {
        public Marks(string subject, int score)
        {
            Subject = subject;
            Score = score;
        }

        public string Subject { get; set; }        
        public int Score { get; set; }

        public int Id { get; set; }

        public Marks()
        {
            Subject = string.Empty;
            Score = 0;
        }

    }
}
