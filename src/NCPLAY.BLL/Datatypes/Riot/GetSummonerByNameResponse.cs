namespace NCPLAY.BLL.Datatypes.Riot
{
    public class GetSummonerByNameResponse : ApiResponse
    {
        public long id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public long summonerLevel { get; set; }
    }
}