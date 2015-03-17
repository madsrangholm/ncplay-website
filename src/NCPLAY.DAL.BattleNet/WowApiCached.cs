using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.BattleNet.WoW;
using NCPLAY.BLL.Interfaces;
using NCPLAY.BLL.Interfaces.BattleNet;

namespace NCPLAY.DAL.BattleNet
{
	public class WowApiCached : WowApi, IWowApi
	{
		private readonly IObjectCache _cache;
		private readonly TimeSpan _validDuration = new TimeSpan(0, 30, 0);
		public WowApiCached(IBattleNetConfig config, IObjectCache cache) : base(config)
		{
			_cache = cache;
		}

		private const string GetAchievementCacheKey = "GetAchievementCacheKey";
		public new async Task<AchievementResponse> GetAchievement(int id)
		{
			var key = string.Format("{0};{1}", GetAchievementCacheKey, id);
			AchievementResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetAchievement(id);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetAuctionDataStatusCacheKey = "GetAuctionDataStatusCacheKey";
        public new async Task<AuctionDataResponse> GetAuctionDataStatus(string realm)
		{
			var key = string.Format("{0};{1}", GetAuctionDataStatusCacheKey, realm);
	        AuctionDataResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetAuctionDataStatus(realm);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetBattlepetAbilitiesCacheKey = "GetBattlepetAbilitiesCacheKey";
        public new async Task<BattlepetAbilitiesResponse> GetBattlepetAbilities(int abilityId)
		{
			var key = string.Format("{0};{1}", GetBattlepetAbilitiesCacheKey, abilityId);
			BattlepetAbilitiesResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetBattlepetAbilities(abilityId);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetBattlepetSpeciesCacheKey = "GetBattlepetSpeciesCacheKey";
        public new async Task<BattlepetSpeciesResponse> GetBattlepetSpecies(int speciesId)
		{
			var key = string.Format("{0};{1}", GetBattlepetSpeciesCacheKey, speciesId);
			BattlepetSpeciesResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetBattlepetSpecies(speciesId);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetBattlepetStatsCacheKey = "GetBattlepetStatsCacheKey";
        public new async Task<BattlepetStatsResponse> GetBattlepetStats(int speciesId, int level = 1, int breedId = 3, int qualityId = 1)
		{
			var key = string.Format("{0};{1};{2};{3};{4}", GetBattlepetStatsCacheKey, speciesId, level, breedId, qualityId);
			BattlepetStatsResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetBattlepetStats(speciesId, level, breedId, qualityId);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetChallengeLeaderboardRealmCacheKey = "GetChallengeLeaderboardRealmCacheKey";
        public new async Task<ChallengeResponse> GetChallengeLeaderboardRealm(string realm)
		{
			var key = string.Format("{0};{1}", GetChallengeLeaderboardRealmCacheKey, realm);
			ChallengeResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetChallengeLeaderboardRealm(realm);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetChallengeLeaderboardRegionCacheKey = "GetChallengeLeaderboardRegionCacheKey";
        public new async Task<ChallengeResponse> GetChallengeLeaderboardRegion()
        {
	        const string key = GetChallengeLeaderboardRegionCacheKey;
			ChallengeResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetChallengeLeaderboardRegion();
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetCharacterProfileCacheKey = "GetCharacterProfileCacheKey";
        public new async Task<CharacterProfileResponse> GetCharacterProfile(string realm, string characterName, IEnumerable<CharacterProfileResponse.CharacterProfileField> fields = null)
        {
			var fieldsString = string.Empty;
			if (fields != null)
	        {
		        fieldsString = fields.Aggregate(fieldsString, (current, field) => current + field.ToString());
	        }
			var key = string.Format("{0};{1};{2};{3}", GetCharacterProfileCacheKey, realm, characterName, fieldsString);
			CharacterProfileResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetCharacterProfile(realm, characterName, fields);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetItemCacheKey = "GetItemCacheKey";
        public new async Task<ItemResponse> GetItem(int id)
		{
			var key = string.Format("{0};{1}", GetItemCacheKey, id);
			ItemResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetItem(id);
			_cache.Set(key, response, _validDuration);
			return response;
		}
	}
}