using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class AchievementsResponse : ApiResponse
    {
        public List<AchievementItem> Achievements { get; set; }
        public List<CategoryItem> Categories { get; set; } 
        public class AchievementItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public long AchievementId { get; set; }
            public long CategoryId { get; set; }
            public int Points { get; set; }
            public IconItem Icon { get; set; }
            public class IconItem
            {
                public int X { get; set; }
                public int Y { get; set; }
                public int W { get; set; }
                public int H { get; set; }
                public int Offset { get; set; }
                public string Url { get; set; }
            }
        }
        public class CategoryItem
        {
            public string Title { get; set; }
            public long CategoryId { get; set; }
            public long FeaturedAchievementId { get; set; }
            public List<CategoryItem> Children { get; set; }        
        }
    }
}
