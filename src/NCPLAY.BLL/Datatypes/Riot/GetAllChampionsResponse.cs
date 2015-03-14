using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Riot
{
    public class GetAllChampionsResponse : ApiResponse
    {
        public List<ChampionDto> champions { get; set; }
    }

    public class ChampionDto
    {
        public bool active { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool freeToPlay { get; set; }
        public long id { get; set; }
        public bool rankedPlayEnabled { get; set; }
    }
}