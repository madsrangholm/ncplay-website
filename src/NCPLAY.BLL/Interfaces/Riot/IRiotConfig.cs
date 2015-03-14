using NCPLAY.BLL.Config;

namespace NCPLAY.BLL.Interfaces.Riot
{
    public interface IRiotConfig
    {
        string ApiKey { get; }
        RiotConfig.LolConfigElement LolConfig { get; }
    }
}