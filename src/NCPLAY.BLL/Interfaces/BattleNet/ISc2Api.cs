using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.BattleNet.Starcraft2;

namespace NCPLAY.BLL.Interfaces.BattleNet
{
    [ContractClassFor(typeof (ISc2Api))]
    internal abstract class Sc2Contracts : ISc2Api
    {
        public Task<ProfileResponse> GetProfile(int id, string name)
        {
            Contract.Requires(0 < id,"id must be greater than 0");
            Contract.Requires(!string.IsNullOrEmpty(name), "name cannot be null or empty");
            Contract.Ensures(Contract.Result<Task<ProfileResponse>>().Result != null);
            return default(Task<ProfileResponse>);
        }


        public Task<ProfileLaddersResponse> GetProfileLadders(int id, string name)
        {
            Contract.Requires(0 < id, "id must be greater than 0");
            Contract.Requires(!string.IsNullOrEmpty(name), "name cannot be null or empty");
            Contract.Ensures(Contract.Result<Task<ProfileLaddersResponse>>().Result != null);
            return default(Task<ProfileLaddersResponse>);
        }


        public Task<ProfileMatchHistoryResponse> GetProfileMatchHistory(int id, string name)
        {
            Contract.Requires(0 < id, "id must be greater than 0");
            Contract.Requires(!string.IsNullOrEmpty(name), "name cannot be null or empty");
            Contract.Ensures(Contract.Result<Task<ProfileMatchHistoryResponse>>().Result != null);
            return default(Task<ProfileMatchHistoryResponse>);
        }


        public Task<LadderResponse> GetLadder(int id)
        {
            Contract.Requires(0 < id, "id must be greater than 0");
            Contract.Ensures(Contract.Result<Task<LadderResponse>>().Result != null);
            return default(Task<LadderResponse>);
        }


        public Task<AchievementsResponse> GetAchievements()
        {
            Contract.Ensures(Contract.Result<Task<AchievementsResponse>>().Result != null);
            return default(Task<AchievementsResponse>);
        }


        public Task<RewardsResponse> GetRewards()
        {
            Contract.Ensures(Contract.Result<Task<RewardsResponse>>().Result != null);
            return default(Task<RewardsResponse>);
        }
    }
    [ContractClass(typeof(Sc2Contracts))]
    public interface ISc2Api
    {
        Task<ProfileResponse> GetProfile(int id, string name);
        Task<ProfileLaddersResponse> GetProfileLadders(int id, string name);
        Task<ProfileMatchHistoryResponse> GetProfileMatchHistory(int id, string name);
        Task<LadderResponse> GetLadder(int id);
        Task<AchievementsResponse> GetAchievements();
        Task<RewardsResponse> GetRewards();
    }
}
