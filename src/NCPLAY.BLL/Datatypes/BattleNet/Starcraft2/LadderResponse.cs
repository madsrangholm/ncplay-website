using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class LadderResponse : ApiResponse
    {
        public List<LadderMember> LadderMembers { get; set; } 
        public class LadderMember
        {
            public CharacterItem Character { get; set; }
            public long JoinTimestamp { get; set; }
            public double Points { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int HighestRank { get; set; }
            public int PreviousRank { get; set; }
            public Sc2Race FavoriteRaceP1 { get; set; }
            public Sc2Race FavoriteRaceP2 { get; set; }

            public class CharacterItem
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
