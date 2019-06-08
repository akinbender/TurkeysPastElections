using System;
using System.Collections.Generic;

namespace ElectionResults.Models
{
    public class Politician
    {
        public string Name { get; set; }
        public string TwitterFollowerUrl { get; set; }
        public Dictionary<DateTime, int> TwitterFollowerCount { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
