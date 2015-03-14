using System.Collections.Generic;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.Riot;

namespace NCPLAY.BLL.Interfaces.Riot
{
    public interface IRiotWebApi
    {
        Task<Dictionary<string, GetSummonerByNameResponse>> GetSummonerByName(string region, string summonerNames);

        Task<GetRecentGamesBySummonerIdResponse> GetRecentGamesBySummonerId(string region, string summonerId);

        Task<GetCurrentGameInfoResponse> GetCurrentGameBySummonerId(string region, string platformId, string summonerId);

        Task<GetAllChampionsResponse> GetAllChampions(string region);

        Task<Dictionary<string, List<LeagueDto>>> GetLeaguesMappedBySummonerId(string region, string summonerId);
    }
}