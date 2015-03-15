using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.Steam;
using NCPLAY.BLL.Interfaces.Steam;
using NCPLAY.BLL.Helpers;
using NCPLAY.BLL.Datatypes;
using System;

namespace NCPLAY.DAL.Steam
{
    public class Dota2Api : JsonBase, IDota2Api
    {
        private readonly ISteamConfig _config;

        public Dota2Api(ISteamConfig config)
        {
            _config = config;
        }

        public async Task<GetMatchHistoryResponse> GetMatchHistory(long accountId)
        {
            return await JsonGetObject<GetMatchHistoryResponse, EmptyErrorResponse>(
                string.Format("{0}?key={1}&account_id={2}",
                    _config.Dota2Config.GetMatchHistoryUri,
                    _config.ApiKey,
                    accountId));
        }
    }
}