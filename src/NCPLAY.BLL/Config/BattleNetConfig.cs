using Microsoft.Framework.ConfigurationModel;
using NCPLAY.BLL.Interfaces.BattleNet;

namespace NCPLAY.BLL.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class BattleNetConfig : IBattleNetConfig
    {
	    private readonly IConfiguration _config;
	    private const string Prefix = "apiConfig:battleNet:";

	    public BattleNetConfig(IConfiguration config)
	    {
		    _config = config;
		    //_config = new Configuration().AddJsonFile("apiConfig.json");
		    WowConfig = new WowConfigElement(_config, Prefix + "wowConfig:");
			Sc2Config = new Sc2ConfigElement(_config, Prefix + "sc2Config:");
	    }
        /// <summary>
        /// 
        /// </summary>
        public string ApiKey => _config.Get(Prefix + "apiKey");

	    /// <summary>
        /// 
        /// </summary>
        public string Locale => _config.Get(Prefix + "locale");

	    /// <summary>
        /// 
        /// </summary>
        public string ThumbnailUrlPrefix => _config.Get(Prefix + "thumbnailUrlPrefix");

	    /// <summary>
	    /// 
	    /// </summary>
	    public WowConfigElement WowConfig { get; private set; }

	    /// <summary>
	    /// 
	    /// </summary>
		public Sc2ConfigElement Sc2Config { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public class WowConfigElement
        {
			private readonly IConfiguration _config;
			private readonly string _prefix;

			public WowConfigElement(IConfiguration config, string prefix)
			{
				_config = config;
				_prefix = prefix;
			}
			/// <summary>
			/// 
			/// </summary>
            public string IconUrlPrefix => _config.Get(_prefix + "iconUrlPrefix");

	        /// <summary>
            /// 
            /// </summary>
            public string IconFileExtension => _config.Get(_prefix + "iconFileExtension");

	        /// <summary>
            /// 
            /// </summary>
            public string BackgroundImageUrlPrefix => _config.Get(_prefix + "backgroundImageUrlPrefix");

	        /// <summary>
            /// 
            /// </summary>
            public string BackgroundImageFileExtension => _config.Get(_prefix + "backgroundImageFileExtension");

	        /// <summary>
			/// 
			/// </summary>
			public string ApiUrl => _config.Get(_prefix + "apiUrl");
        }

        public class Sc2ConfigElement
        {
			private readonly IConfiguration _config;
			private readonly string _prefix;

			public Sc2ConfigElement(IConfiguration config, string prefix)
			{
				_config = config;
				_prefix = prefix;
			}
            public string ProfilePathPrefix => _config.Get(_prefix + "profilePathPrefix");

	        /// <summary>
			/// 
			/// </summary>
			public string ApiUrl => _config.Get(_prefix + "apiUrl");
        }
    }
}