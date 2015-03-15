using Microsoft.Framework.ConfigurationModel;
using NCPLAY.BLL.Interfaces.Steam;

namespace NCPLAY.BLL.Config
{
	public class SteamConfig : ISteamConfig
	{
		private readonly IConfiguration _config;
        private const string Prefix = "apiConfig:steamWebApi:";

        public SteamConfig(IConfiguration config)
        {
	        _config = config;
            Dota2Config = new Dota2ConfigElement(_config, Prefix + "dota2Config:");
        }

		public string ApiKey => _config.Get(Prefix + "apiKey");
		public string SupportedApiListUri => _config.Get(Prefix + "supportedApiListUri");
		public string PlayerSummariesUri => _config.Get(Prefix + "playerSummariesUri");
		public string AppListUri => _config.Get(Prefix + "appListUri");

        /// <summary>
        /// 
        /// </summary>
        public Dota2ConfigElement Dota2Config { get; private set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Dota2ConfigElement
    {
        private readonly IConfiguration _config;
        private readonly string _prefix;

        public Dota2ConfigElement(IConfiguration config, string prefix)
        {
            _config = config;
            _prefix = prefix;
        }
        public string GetMatchHistoryUri => _config.Get(_prefix + "getMatchHistoryUri");

        public string GetHeroesUri => _config.Get(_prefix + "getHeroesUri");
    }
}