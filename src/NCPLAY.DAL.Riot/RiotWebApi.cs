using System.Collections.Generic;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes;
using NCPLAY.BLL.Datatypes.Riot;
using NCPLAY.BLL.Helpers;
using NCPLAY.BLL.Interfaces.Riot;

namespace NCPLAY.DAL.Riot
{
    public class RiotWebApi : JsonBase, IRiotWebApi
    {
        private const string _apiKey = "5a2103f6-c371-4d8d-bbda-52eb5de985cf";

        private const string _region = "eune";
        private const string _platformId = "EUN1";


        private readonly IRiotConfig _config;

        public RiotWebApi(IRiotConfig config)
        {
            _config = config;
        }

        public async Task<Dictionary<string, GetSummonerByNameResponse>> GetSummonerByName(string region,
            string summonerNames)
        {
            var replacer = new TokenReplacer(
                new KeyValuePair<string, string>("region", region),
                new KeyValuePair<string, string>("summonernames", summonerNames),
                new KeyValuePair<string, string>("apikey", _config.ApiKey)
                );

            return await JsonGetDictionary<string, GetSummonerByNameResponse, EmptyErrorResponse>(
                replacer.Replace(_config.LolConfig.SummonerByNameResponseUri));
        }

        public async Task<GetRecentGamesBySummonerIdResponse> GetRecentGamesBySummonerId(string region,
            string summonerId)
        {
            var replacer = new TokenReplacer(
                new KeyValuePair<string, string>("region", region),
                new KeyValuePair<string, string>("summonerid", summonerId),
                new KeyValuePair<string, string>("apikey", _config.ApiKey)
                );

            return await JsonGetObject<GetRecentGamesBySummonerIdResponse, EmptyErrorResponse>(
                replacer.Replace(_config.LolConfig.RecentGamesBySummonerIdUri));
        }

        public async Task<GetCurrentGameInfoResponse> GetCurrentGameBySummonerId(string region, string platformId,
            string summonerId)
        {
            var replacer = new TokenReplacer(
                new KeyValuePair<string, string>("region", region),
                new KeyValuePair<string, string>("platformid", platformId),
                new KeyValuePair<string, string>("summonerid", summonerId),
                new KeyValuePair<string, string>("apikey", _config.ApiKey)
                );

            return
                await
                    JsonGetObject<GetCurrentGameInfoResponse, EmptyErrorResponse>(
                        replacer.Replace(_config.LolConfig.CurrentGameBySummonerIdUri));
        }

        public async Task<GetAllChampionsResponse> GetAllChampions(string region)
        {
            var replacer = new TokenReplacer(
                new KeyValuePair<string, string>("region", region),
                new KeyValuePair<string, string>("apikey", _config.ApiKey)
                );

            return
                await
                    JsonGetObject<GetAllChampionsResponse, EmptyErrorResponse>(
                        replacer.Replace(_config.LolConfig.AllChampionsUri));
        }


        public async Task<Dictionary<string, List<LeagueDto>>> GetLeaguesMappedBySummonerId(string region,
            string summonerId)
        {
            var replacer = new TokenReplacer(
                new KeyValuePair<string, string>("region", region),
                new KeyValuePair<string, string>("summonerid", summonerId),
                new KeyValuePair<string, string>("apikey", _config.ApiKey)
                );

            return
                await
                    JsonGetDictionaryWithLists<string, LeagueDto, EmptyErrorResponse>(
                        replacer.Replace(_config.LolConfig.LeaguesMappedBySummonerIdUri));
        }
    }
}