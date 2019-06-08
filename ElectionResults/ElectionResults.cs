using ElectionResults.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectionResults
{
    public static class ElectionResults
    {
        public static IEnumerable<Election> PastElections
        {
            get
            {
                var participants = Participants.ToList();
                var electionList = new List<Election>()
                {
                    new Election
                    {
                        Date = new DateTime(2018,6,24),
                        TotalChairCount = 550
                    },
                    new Election
                    {
                        Date = new DateTime(2015,11,1),
                        TotalChairCount = 550
                    },
                    new Election
                    {
                        Date = new DateTime(2015,6,7),
                        TotalChairCount = 550
                    },
                    new Election
                    {
                        Date = new DateTime(2011,6,12),
                        TotalChairCount = 550
                    }
                };
                foreach (var election in electionList)
                {
                    election.Participants = participants;
                    if (election.Date == new DateTime(2018, 6, 24))
                    {
                        participants.First(a => a.Party == Participant.PoliticalParty.Akp).AssignPartyToElection(election, 42.56d, 295);
                        participants.First(a => a.Party == Participant.PoliticalParty.Chp).AssignPartyToElection(election, 22.65d, 146);
                        participants.First(a => a.Party == Participant.PoliticalParty.Hdp).AssignPartyToElection(election, 11.70d, 67);
                        participants.First(a => a.Party == Participant.PoliticalParty.Mhp).AssignPartyToElection(election, 11.10d, 49);
                        participants.First(a => a.Party == Participant.PoliticalParty.Ip).AssignPartyToElection(election, 9.96d, 43);

                    }
                    else if (election.Date == new DateTime(2015, 11, 1))
                    {
                        participants.First(a => a.Party == Participant.PoliticalParty.Akp).AssignPartyToElection(election, 49.5d, 317);
                        participants.First(a => a.Party == Participant.PoliticalParty.Chp).AssignPartyToElection(election, 25.3d, 134);
                        participants.First(a => a.Party == Participant.PoliticalParty.Hdp).AssignPartyToElection(election, 10.7d, 59);
                        participants.First(a => a.Party == Participant.PoliticalParty.Mhp).AssignPartyToElection(election, 11.9d, 40);
                    }
                    else if (election.Date == new DateTime(2015, 6, 7))
                    {
                        participants.First(a => a.Party == Participant.PoliticalParty.Akp).AssignPartyToElection(election, 40.8d, 258);
                        participants.First(a => a.Party == Participant.PoliticalParty.Chp).AssignPartyToElection(election, 24.9d, 132);
                        participants.First(a => a.Party == Participant.PoliticalParty.Hdp).AssignPartyToElection(election, 13.1d, 80);
                        participants.First(a => a.Party == Participant.PoliticalParty.Mhp).AssignPartyToElection(election, 16.2d, 80);
                    }
                    else if (election.Date == new DateTime(2011, 6, 12))
                    {
                        participants.First(a => a.Party == Participant.PoliticalParty.Akp).AssignPartyToElection(election, 49.8d, 327);
                        participants.First(a => a.Party == Participant.PoliticalParty.Chp).AssignPartyToElection(election, 25.9d, 135);
                        participants.First(a => a.Party == Participant.PoliticalParty.Mhp).AssignPartyToElection(election, 13d, 53);
                        participants.First(a => a.Party == Participant.PoliticalParty.Independent).AssignPartyToElection(election, 6.6d, 35);
                    }
                }
                return electionList;
            }
        }

        private static IEnumerable<Politician> Politicians { get; } = new List<Politician>()
        {
            new Politician
            {
                Name = "Recep Tayyip Erdoğan",
                TwitterFollowerUrl = "https://www.boomsocial.com/Twitter/Hesap/RTErdogan-68034431"
            },
            new Politician
            {
                Name = "Devlet Bahçeli",
                TwitterFollowerUrl = "https://www.boomsocial.com/Twitter/Hesap/dbdevletbahceli-214017108"
            },
            new Politician
            {
                Name = "Kemal Kılıçdaroğlu",
                TwitterFollowerUrl = "https://www.boomsocial.com/Twitter/Hesap/kilicdarogluk-154140901"
            },
            new Politician
            {
                Name = "Meral Akşener",
                TwitterFollowerUrl = "https://www.boomsocial.com/Twitter/Hesap/meral_aksener-590346965"
            },
            new Politician
            {
                Name = "Selahattin Demirtaş",
                TwitterFollowerUrl = "https://www.boomsocial.com/Twitter/Hesap/hdpdemirtas-224609329"
            }
        };

        private static IEnumerable<Participant> Participants
        {
            get
            {
                var politicians = Politicians.ToList();
                return new List<Participant>
                {
                    new Participant
                    {
                        Party = Participant.PoliticalParty.Akp,
                        LeadingPolitician = politicians.First(a => a.Name == "Recep Tayyip Erdoğan")
                    },
                    new Participant
                    {
                        Party = Participant.PoliticalParty.Chp,
                        LeadingPolitician = politicians.First(a => a.Name == "Kemal Kılıçdaroğlu")
                    },
                    new Participant
                    {
                        Party = Participant.PoliticalParty.Hdp,
                        LeadingPolitician = politicians.First(a => a.Name == "Selahattin Demirtaş")
                    },
                    new Participant
                    {
                        Party = Participant.PoliticalParty.Mhp,
                        LeadingPolitician = politicians.First(a => a.Name == "Devlet Bahçeli")
                    },
                    new Participant
                    {
                        Party = Participant.PoliticalParty.Ip,
                        LeadingPolitician = politicians.First(a => a.Name == "Meral Akşener")
                    },
                    new Participant
                    {
                        Party = Participant.PoliticalParty.Independent,
                        LeadingPolitician = null
                    }
                };
            }
        }
    }
}