using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.Steam;

namespace NCPLAY.BLL.Interfaces.Steam
{
    //[ContractClassFor(typeof (IDota2Api))]
    internal abstract class Dota2Contracts : IDota2Api
    {
        public Task<GetMatchHistoryResponse> GetMatchHistory(long accountId)
        {
            //Contract.Ensures(//Contract.Result<Task<SupportedApiListResponse>>().Result != null);
            return default(Task<GetMatchHistoryResponse>);
        }
    }

    //[ContractClass(typeof (Dota2Contracts))]
    public interface IDota2Api
    {
        Task<GetMatchHistoryResponse> GetMatchHistory(long accountId);
    }
}