using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class ProfileLaddersResponse : ApiResponse
    {
        public List<SeasonItem> CurrentSeason { get; set; }
        public List<SeasonItem> PreviousSeason { get; set; }
        public List<SeasonItem> ShowcasePlacement { get; set; } //TODO: Find out what type this is!!

        public class SeasonItem
        {
            public List<LadderItem> Ladder { get; set; }
            public List<CharactersItem> Characters { get; set; }
            public List<string> NonRanked { get; set; }  //TODO: Find out what type this is 
            public class LadderItem
            {
                public string LadderName { get; set; }
                public long LadderId { get; set; }
                public int Division { get; set; }
                public int Rank { get; set; }
                public Sc2League League { get; set; }
                public string MatchMakingQueue { get; set; }
                public int Wins { get; set; }
                public int Losses { get; set; }
                public bool Showcase { get; set; }
            }

            public class CharactersItem
            {
                public long Id { get; set; }
                public int Realm { get; set; }
                public string DisplayName { get; set; }
                public string ClanName { get; set; }
                public string ClanTag { get; set; }
                public string ProfilePath { get; set; }
            }
        }
        
    }
}
