using NCPLAY.BLL.Config;

namespace NCPLAY.BLL.Interfaces.Steam
{
    public interface ISteamConfig
    {
        string ApiKey { get; }
        string SupportedApiListUri { get; }
        string PlayerSummariesUri { get; }
        string AppListUri { get; }

        Dota2ConfigElement Dota2Config { get; }
    }
}