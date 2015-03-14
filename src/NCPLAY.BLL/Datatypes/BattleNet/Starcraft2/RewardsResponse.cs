using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class RewardsResponse : ApiResponse
    {
        public List<PortraitItem> Portraits { get; set; }
        public List<PortraitItem> TerranDecals { get; set; }
        public List<PortraitItem> ProtossDecals { get; set; }
        public List<PortraitItem> ZergDecals { get; set; }
        public List<SkinItem> Skins { get; set; }
        public List<AnimationItem> Animations { get; set; } 
        public class IconItem
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int Offset { get; set; }
            public string Url { get; set; }
        }
        public class PortraitItem
        {
            public string Title { get; set; }
            public long Id { get; set; }
            public IconItem Icon { get; set; }
            public long AchievementId { get; set; }     
        }
        public class SkinItem
        {
            public string Name { get; set; }
            public string Title { get; set; }
            public long Id { get; set; }
            public IconItem Icon { get; set; }
            public long AchievementId { get; set; }
        }
        public class AnimationItem
        {
            public string Title { get; set; }
            public string Command { get; set; }
            public long Id { get; set; }
            public IconItem Icon { get; set; }
            public long AchievementId { get; set; }
        }
    }
}
