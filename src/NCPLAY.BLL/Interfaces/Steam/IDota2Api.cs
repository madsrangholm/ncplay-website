using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.Steam;
using NCPLAY.BLL.Datatypes.Steam.Dota2;

namespace NCPLAY.BLL.Interfaces.Steam
{
    //[ContractClassFor(typeof (IDota2Api))]
    internal abstract class Dota2Contracts : IDota2Api
    {
        public Task<GetMatchHistoryResponse> GetMatchHistory(long accountId)
        {
            //Contract.Ensures(//Contract.Result<Task<GetMatchHistoryResponse>>().Result != null);
            return default(Task<GetMatchHistoryResponse>);
        }
        public Task<GetHeroesResponse> GetHeroes(string language)
        {
            //Contract.Ensures(//Contract.Result<Task<GetHeroesResponse>>().Result != null);
            return default(Task<GetHeroesResponse>);
        }
    }

    //[ContractClass(typeof (Dota2Contracts))]
    public interface IDota2Api
    {
        Task<GetMatchHistoryResponse> GetMatchHistory(long accountId);

        Task<GetHeroesResponse> GetHeroes(string language);
        
    }
}