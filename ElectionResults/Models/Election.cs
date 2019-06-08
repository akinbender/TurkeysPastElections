using System;
using System.Collections.Generic;

namespace ElectionResults.Models
{
    public class Election
    {
        public DateTime Date { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
        public int TotalChairCount { get; set; }
    }
}
