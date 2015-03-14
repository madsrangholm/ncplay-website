using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Riot
{
    //public class GetLeaguesMappedBySummonerIdResponse : ApiResponse
    //{
    //    private List<LeagueDto> leaguesDto;
    //}

    public class LeagueDto : ApiResponse
    {
        public List<LeagueEntryDto> entries { get; set; }
        public string name { get; set; }
        public string participantId { get; set; }
        public string queue { get; set; }
        public string tier { get; set; }
    }

    public class LeagueEntryDto
    {
        public string division { get; set; }
        public bool isFreshBlood { get; set; }
        public bool isHotStreak { get; set; }
        public bool isInactive { get; set; }
        public bool isVeteran { get; set; }
        public int leaguePoints { get; set; }
        public int losses { get; set; }
        public MiniSeriesDto miniSeries { get; set; }
        public string playerOrTeamId { get; set; }
        public string playerOrTeamName { get; set; }
        public int wins { get; set; }
    }

    public class MiniSeriesDto
    {
        public int losses { get; set; }
        public string progress { get; set; }
        public int target { get; set; }
        public int wins { get; set; }
    }
}