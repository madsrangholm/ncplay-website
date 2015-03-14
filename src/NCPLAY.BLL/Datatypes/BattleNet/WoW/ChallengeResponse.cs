using System;
using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class ChallengeResponse : ApiResponse
    {
        public List<ChallengeElement> Challenge { get; set; }

        public class ChallengeElement
        {
            public List<GroupElement> Groups { get; set; }
            public MapElement Map { get; set; }
            public RealmElement Realm { get; set; }


            public class GroupElement
            {
                public int Ranking { get; set; }
                public TimeElement Time { get; set; }
                public DateTime Date { get; set; }
                public string Medal { get; set; }
                public string Faction { get; set; }
                public bool IsRecurring { get; set; }
                public List<MemberElement> Members { get; set; }

                public class MemberElement
                {
                    public CharacterElement Character { get; set; }
                    public SpecElement Spec { get; set; }

                    public class CharacterElement
                    {
                        public string Name { get; set; }
                        public string Realm { get; set; }
                        public string BattleGroup { get; set; }
                        public int Class { get; set; }
                        public int Race { get; set; }
                        public int Gender { get; set; }
                        public int Level { get; set; }
                        public long AchievementPoints { get; set; }
                        public string Thumbnail { get; set; }
                        public SpecElement Spec { get; set; }
                    }

                    public class SpecElement
                    {
                        public string Name { get; set; }
                        public string Role { get; set; }
                        public string BackgroundImage { get; set; }
                        public string Icon { get; set; }
                        public string Description { get; set; }
                        public int Order { get; set; }
                    }
                }
            }

            public class MapElement
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Slug { get; set; }
                public bool HasChallengeMode { get; set; }
                public TimeElement BronzeCriteria { get; set; }
                public TimeElement SilverCriteria { get; set; }
                public TimeElement GoldCriteria { get; set; }
            }

            public class RealmElement
            {
                public string Name { get; set; }
                public string Slug { get; set; }
                public string BattleGroup { get; set; }
                public string Locale { get; set; }
                public string TimeZone { get; set; }
                public List<string> Connected_Realms { get; set; }
            }
        }

        public class TimeElement
        {
            public long Time { get; set; }
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public int MilliSeconds { get; set; }
            public bool IsPositive { get; set; }
        }
    }
}