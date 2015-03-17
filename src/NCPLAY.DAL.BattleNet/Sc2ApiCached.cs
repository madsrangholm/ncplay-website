using System;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.BattleNet.Starcraft2;
using NCPLAY.BLL.Interfaces;
using NCPLAY.BLL.Interfaces.BattleNet;

namespace NCPLAY.DAL.BattleNet
{
    public class Sc2ApiCached : Sc2Api, ISc2Api
    {
        private readonly IObjectCache _cache;
		private readonly TimeSpan _validDuration = new TimeSpan(0,30,0);
        public Sc2ApiCached(IObjectCache cache, IBattleNetConfig config) : base(config)
        {
			_cache = cache;
        }

        private const string GetProfileKey = "Sc2GetProfileKey";
        public new async Task<ProfileResponse> GetProfile(int id, string name)
        {
            var key = string.Format("{0};{1};{2}", GetProfileKey, id, name);
	        ProfileResponse cachedValue;
            if (_cache.Get(key, out cachedValue))
            {
	            return cachedValue;
            }
            var response = await base.GetProfile(id, name);
            _cache.Set(key, response, _validDuration);
            return response;
        }
        private const string GetProfileLaddersKey = "Sc2GetProfileLaddersKey";
        public new async Task<ProfileLaddersResponse> GetProfileLadders(int id, string name)
        {
            var key = string.Format("{0};{1};{2}", GetProfileLaddersKey, id, name);
	        ProfileLaddersResponse cachedValue;
            if (_cache.Get(key, out cachedValue))
            {
	            return cachedValue;
            }
            var response = await base.GetProfileLadders(id, name);
            _cache.Set(key, response, _validDuration);
            return response;
        }
        private const string GetProfileMatchHistoryKey = "Sc2GetProfileMatchHistoryKey";
        public new async Task<ProfileMatchHistoryResponse> GetProfileMatchHistory(int id, string name)
        {
            var key = string.Format("{0};{1};{2}", GetProfileMatchHistoryKey, id, name);
	        ProfileMatchHistoryResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetProfileMatchHistory(id, name);
            _cache.Set(key, response, _validDuration);
            return response;
        }
        private const string GetLadderKey = "Sc2GetLadderKey";
        public new async Task<LadderResponse> GetLadder(int id)
        {
            var key = string.Format("{0};{1}", GetLadderKey, id);
	        LadderResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetLadder(id);
            _cache.Set(key, response, _validDuration);
            return response;
        }
        private const string GetAchievementsKey = "Sc2GetAchievementsKey";
        public new async Task<AchievementsResponse> GetAchievements()
        {
	        AchievementsResponse cachedValue;
			if (_cache.Get(GetAchievementsKey, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetAchievements();
            _cache.Set(GetAchievementsKey, response, _validDuration);
            return response;
        }
        private const string GetRewardsKey = "Sc2GetRewardsKey";
        new async Task<RewardsResponse> GetRewards()
        {
	        RewardsResponse cachedValue;
			if (_cache.Get(GetAchievementsKey, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetRewards();
            _cache.Set(GetRewardsKey, response, _validDuration);
            return response;
        }
    }
}
