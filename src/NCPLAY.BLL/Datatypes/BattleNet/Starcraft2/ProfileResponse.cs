using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class ProfileResponse : ApiResponse
    {
        public long Id { get; set; }
        public int Realm { get; set; }
        public string DisplayName { get; set; }
        public string ClanName { get; set; }
        public string ClanTag { get; set; }
        public string ProfilePath { get; set; }
        public ProfilePortrait Portrait { get; set; }
        public ProfileCareer Career { get; set; }
        public ProfileSwarmLevels SwarmLevels { get; set; }
        public ProfileCampaign Campaign { get; set; }
        public ProfileSeason Season { get; set; }
        public ProfileRewards Rewards { get; set; }
        public ProfileAchievements Achievements { get; set; }
        public class ProfilePortrait
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int Offset { get; set; }
            public string Url { get; set; }
        }
        public class ProfileCareer
        {
            public Sc2Race PrimaryRace { get; set; }
            public int TerranWins { get; set; }
            public int ProtossWins { get; set; }
            public int ZergWins { get; set; }
            public Sc2League Highest1v1Rank { get; set; }
            public Sc2League HighestTeamRank { get; set; }
            public int SeasonTotalGames { get; set; }
            public int CareerTotalGames { get; set; }

        }
        public class ProfileSwarmLevels
        {
            public int Level { get; set; }
            public SwarmRace Terran { get; set; }
            public SwarmRace Protoss { get; set; }
            public SwarmRace Zerg { get; set; }
            public class SwarmRace
            {
                public int Level { get; set; }
                public long TotalLevelXp { get; set; }
                public long CurrentLevelXp { get; set; }
            }
        }
        public class ProfileCampaign
        {
            public string Wol { get; set; }
            public string Hots { get; set; }
        }
        public class ProfileSeason
        {
            public int SeasonId { get; set; }
            public int SeasonNumber { get; set; }
            public int SeasonYear { get; set; }
            public int TotalGamesThisSeason { get; set; }
        }
        public class ProfileRewards
        {
            public List<long> Selected { get; set; }
            public List<long> Earned { get; set; } 
        }
        public class ProfileAchievements
        {
            public AchievementPoints Points { get; set; }
            public List<AchievementItem> Achievements { get; set; } 
            public class AchievementPoints
            {
                public int TotalPoints { get; set; }
                public Dictionary<string, int> CategoryPoints { get; set; }
            }

            public class AchievementItem
            {
                public long AchievementId { get; set; }
                public long CompletionDate { get; set; }
            }
        }
    }
}
