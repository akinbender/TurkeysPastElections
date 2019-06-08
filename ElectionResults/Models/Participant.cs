using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ElectionResults.Models
{
    public class Participant
    {
        public enum PoliticalParty
        {
            [Description("Cumhuriyet Halk Partisi")]
            Chp,
            [Description("Adalet ve Kalkınma Partisi")]
            Akp,
            [Description("Milliyetçi Hareket Partisi")]
            Mhp,
            [Description("Halkların Demokratik Partisi")]
            Hdp,
            [Description("İyi Parti")]
            Ip,
            [Description("Bağımsızlar")]
            Independent
        }

        public PoliticalParty Party { get; set; }

        public IEnumerable<Tuple<DateTime, double, int>> Results { get; set; }

        private Politician _leadingPolitician;

        public Politician LeadingPolitician
        {
            get => _leadingPolitician;
            set
            {
                if (value == null) return;
                value.Participant = this;
                _leadingPolitician = value;
            }
        }
    }

    public static class ParticipantExtensions
    {
        public static void AssignPartyToElection(this Participant participant, Election election, double votingRate,
            int chairCount)
        {
            if (participant.Results == null)
            {
                participant.Results = new List<Tuple<DateTime, double, int>>
                {
                    new Tuple<DateTime, double, int>(election.Date, votingRate, chairCount)
                };
                return;
            }
            else
            {
                var a = participant.Results.ToList();
                a.Add(new Tuple<DateTime, double, int>(election.Date, votingRate, chairCount));
                participant.Results = a;
            }
        }
    }

}
