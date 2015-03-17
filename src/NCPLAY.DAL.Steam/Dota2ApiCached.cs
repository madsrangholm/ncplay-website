using System;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.Steam;
using NCPLAY.BLL.Datatypes.Steam.Dota2;
using NCPLAY.BLL.Interfaces;
using NCPLAY.BLL.Interfaces.Steam;

namespace NCPLAY.DAL.Steam
{
	public class Dota2ApiCached : Dota2Api, IDota2Api
	{
		private readonly IObjectCache _cache;
		private readonly TimeSpan _validDuration = new TimeSpan(0, 30, 0);
		public Dota2ApiCached(ISteamConfig config, IObjectCache cache) : base(config)
		{
			_cache = cache;
		}

		private const string GetMatchHistoryCacheKey = "GetMatchHistoryCacheKey";
        public new async Task<GetMatchHistoryResponse> GetMatchHistory(long accountId)
		{
			var key = string.Format("{0};{1}", GetMatchHistoryCacheKey, accountId);
			GetMatchHistoryResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetMatchHistory(accountId);
			_cache.Set(key, response, _validDuration);
			return response;
		}

		private const string GetHeroesCacheKey = "GetHeroesCacheKey";
        public new async Task<GetHeroesResponse> GetHeroes(string language)
		{
			var key = string.Format("{0};{1}", GetHeroesCacheKey, language);
			GetHeroesResponse cachedValue;
			if (_cache.Get(key, out cachedValue))
			{
				return cachedValue;
			}
			var response = await base.GetHeroes(language);
			_cache.Set(key, response, _validDuration);
			return response;
		}
	}
}