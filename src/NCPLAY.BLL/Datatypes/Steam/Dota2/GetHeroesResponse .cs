using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace NCPLAY.BLL.Datatypes.Steam
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
            // The hero's in-game "code name"
            public string name { get; set; }
            // The hero's numeric ID
            public int id { get; set; }
            // The hero's text name (language specific result - this field is not present if no language is specified)
            public string localized_name { get; set; }
            public string HeroPortaitFullUrl
            {
                get
                {
                    return "http://cdn.dota2.com/apps/dota2/images/heroes/" + name.Replace("npc_dota_hero_", "") + "_full.png";
                }
            }

            public string HeroPortaitLargeUrl
            {
                get
                {
                    return "http://cdn.dota2.com/apps/dota2/images/heroes/" + name.Replace("npc_dota_hero_", "") + "_lg.png";
                }
            }

            public string HeroPortaitSmallUrl
            {
                get
                {
                    return "http://cdn.dota2.com/apps/dota2/images/heroes/" + name.Replace("npc_dota_hero_", "") + "_sb.png";
                }
            }
        }
    }
}