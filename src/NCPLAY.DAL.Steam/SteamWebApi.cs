using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes;
using NCPLAY.BLL.Datatypes.Steam;
using NCPLAY.BLL.Helpers;
using NCPLAY.BLL.Interfaces.Steam;

namespace NCPLAY.DAL.Steam
{
    public class SteamWebApi : JsonBase, ISteamWebApi
    {
        private readonly ISteamConfig _config;

        public SteamWebApi(ISteamConfig config)
        {
            _config = config;
        }

        public async Task<SupportedApiListResponse> GetSupportedApiList()
        {
            return await JsonGetObject<SupportedApiListResponse, EmptyErrorResponse>(
                string.Format("{0}?key={1}",
                    _config.SupportedApiListUri,
                    _config.ApiKey));
        }

        public async Task<GetPlayerSummariesResponse> GetPlayerSummaries(string steamIds)
        {
            return await JsonGetObject<GetPlayerSummariesResponse, EmptyErrorResponse>(
                string.Format("{0}?key={1}&steamids={2}",
                    _config.PlayerSummariesUri,
                    _config.ApiKey,
                    steamIds));
        }

        public async Task<GetAppListResponse> GetAppList()
        {
            return await JsonGetObject<GetAppListResponse, EmptyErrorResponse>(_config.AppListUri);
        }
    }
}