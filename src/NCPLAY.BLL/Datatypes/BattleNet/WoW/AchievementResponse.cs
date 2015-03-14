using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class AchievementResponse : ApiResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public List<AchievementRewardItem> RewardItems { get; set; }
        public string Icon { get; set; }
        public List<AchievementCriterionItem> Criteria { get; set; }
        public bool AccountWide { get; set; }
        public int FactionId { get; set; }


        public class AchievementCriterionItem
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public int OrderIndex { get; set; }
            public int Max { get; set; }
        }

        public class AchievementRewardItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public int Quality { get; set; }
            public int ItemLevel { get; set; }

            /// <summary>
            ///     Datatype not verified
            /// </summary>
            public Dictionary<string, string> TooltipParams { get; set; }

            /// <summary>
            ///     Datatype not verified
            /// </summary>
            public List<string> Stats { get; set; }

            public int Armor { get; set; }
            public string Context { get; set; }

            /// <summary>
            ///     Datatype not verified
            /// </summary>
            public List<string> BonusLists { get; set; }
        }
    }
}