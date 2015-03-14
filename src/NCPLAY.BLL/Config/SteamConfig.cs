using Microsoft.Framework.ConfigurationModel;
using NCPLAY.BLL.Interfaces.Steam;

namespace NCPLAY.BLL.Config
{
	public class SteamConfig : ISteamConfig
	{
		private readonly IConfiguration _config;
		private readonly string _prefix;
        public SteamConfig(IConfiguration config, string prefix)
        {
	        _config = config;
	        _prefix = prefix;
        }
		public string ApiKey => _config.Get(_prefix + "apiKey");
		public string SupportedApiListUri => _config.Get(_prefix + "supportedApiListUri");
		public string PlayerSummariesUri => _config.Get(_prefix + "playerSummariesUri");
		public string AppListUri => _config.Get(_prefix + "appListUri");
	}
}