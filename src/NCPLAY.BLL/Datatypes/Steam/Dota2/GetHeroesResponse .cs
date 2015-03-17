using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Steam.Dota2
{
    public class GetHeroesResponse : ApiResponse
    {
        public HeroDetails Result { get; set; }

        public class HeroDetails
        {
            public List<Hero> Heroes { get; set; }
        }

        public class Hero
        {
            // The hero's in-game "code Name"
            public string Name { get; set; }
            // The hero's numeric ID
            public int Id { get; set; }
            // The hero's text Name (language specific result - this field is not present if no language is specified)
            public string localized_name { get; set; }
            public string HeroPortaitFullUrl => "http://cdn.dota2.com/apps/dota2/images/heroes/" + Name.Replace("npc_dota_hero_", "") + "_full.png";

	        public string HeroPortaitLargeUrl => "http://cdn.dota2.com/apps/dota2/images/heroes/" + Name.Replace("npc_dota_hero_", "") + "_lg.png";

	        public string HeroPortaitSmallUrl => "http://cdn.dota2.com/apps/dota2/images/heroes/" + Name.Replace("npc_dota_hero_", "") + "_sb.png";
        }
    }
}