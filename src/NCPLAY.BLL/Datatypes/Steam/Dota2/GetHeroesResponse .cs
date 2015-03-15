using System.Collections.Generic;
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
        }
    }
}