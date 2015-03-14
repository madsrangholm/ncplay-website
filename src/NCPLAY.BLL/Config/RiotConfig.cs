using Microsoft.Framework.ConfigurationModel;
using NCPLAY.BLL.Interfaces.Riot;

namespace NCPLAY.BLL.Config
{
	public class RiotConfig : IRiotConfig
	{
		private readonly IConfiguration _config;
		private readonly string _prefix;
		public RiotConfig(IConfiguration config, string prefix)
		{
			_config = config;
			_prefix = prefix;
			LolConfig = new LolConfigElement(_config, _prefix + "lolConfig:");
		}
		public string ApiKey => _config.Get(_prefix + "apiKey");
		public LolConfigElement LolConfig { get; private set; }


		public class LolConfigElement
		{
			private readonly IConfiguration _config;
			private readonly string _prefix;
			public LolConfigElement(IConfiguration config, string prefix)
			{
				_config = config;
				_prefix = prefix;
			}
			public string SummonerByNameResponseUri => _config.Get(_prefix + "summonerByNameResponseUri");
			public string RecentGamesBySummonerIdUri => _config.Get(_prefix + "recentGamesBySummonerIdUri");
			public string CurrentGameBySummonerIdUri => _config.Get(_prefix + "currentGameBySummonerIdUri");
			public string AllChampionsUri => _config.Get(_prefix + "allChampionsUri");
			public string LeaguesMappedBySummonerIdUri => _config.Get(_prefix + "leaguesMappedBySummonerIdUri");
		}
	}
}