using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.Steam;

namespace NCPLAY.BLL.Interfaces.Steam
{
    //[ContractClassFor(typeof (ISteamWebApi))]
    internal abstract class SteamWebApiUtilContracts : ISteamWebApi
    {
        public Task<SupportedApiListResponse> GetSupportedApiList()
        {
            //Contract.Ensures(//Contract.Result<Task<SupportedApiListResponse>>().Result != null);
            return default(Task<SupportedApiListResponse>);
        }

        public Task<GetPlayerSummariesResponse> GetPlayerSummaries(string steamIds)
        {
            //Contract.Ensures(//Contract.Result<Task<GetPlayerSummariesResponse>>().Result != null);
            return default(Task<GetPlayerSummariesResponse>);
        }

        public Task<GetAppListResponse> GetAppList()
        {
            //Contract.Ensures(//Contract.Result<Task<GetAppListResponse>>().Result != null);
            return default(Task<GetAppListResponse>);
        }
    }

    //[ContractClass(typeof (SteamWebApiUtilContracts))]
    public interface ISteamWebApi
    {
        Task<SupportedApiListResponse> GetSupportedApiList();
        Task<GetPlayerSummariesResponse> GetPlayerSummaries(string steamIds);
        Task<GetAppListResponse> GetAppList();
    }
}