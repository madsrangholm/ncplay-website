using Microsoft.Framework.Cache.Memory;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using NCPLAY.BLL.Config;
using NCPLAY.BLL.Helpers;
using NCPLAY.BLL.Interfaces;
using NCPLAY.BLL.Interfaces.BattleNet;
using NCPLAY.BLL.Interfaces.Riot;
using NCPLAY.BLL.Interfaces.Steam;
using NCPLAY.DAL.BattleNet;
using NCPLAY.DAL.Riot;
using NCPLAY.DAL.Steam;

namespace NCPLAY.DI
{
    public class Container
    {
	    public static IServiceCollection RegisterServices(IServiceCollection collection, IConfiguration config)
	    {
		    collection
				.AddSingleton(s => config)
			    .AddSingleton<IObjectCache, ObjectCache>()
				.AddTransient<ISc2Api, Sc2ApiCached>()
			    .AddTransient<IWowApi, WowApi>()
			    .AddTransient<IRiotWebApi, RiotWebApi>()
			    .AddTransient<ISteamWebApi, SteamWebApi>()
			    .AddTransient<IBattleNetConfig, BattleNetConfig>();
			return collection;
	    }
    }
}
