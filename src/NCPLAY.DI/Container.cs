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
			    .AddTransient<IObjectCache, ObjectCache>()
				.AddSingleton<ISc2Api, Sc2ApiCached>()
			    .AddSingleton<IWowApi, WowApiCached>()
			    .AddSingleton<IRiotWebApi, RiotWebApi>()
			    .AddSingleton<ISteamWebApi, SteamWebApi>()
                .AddSingleton<IDota2Api, Dota2ApiCached>()
                .AddTransient<IBattleNetConfig, BattleNetConfig>()
                .AddTransient<ISteamConfig, SteamConfig>();
            return collection;
	    }
    }
}
