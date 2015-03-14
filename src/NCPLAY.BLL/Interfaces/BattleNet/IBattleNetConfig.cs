using NCPLAY.BLL.Config;

namespace NCPLAY.BLL.Interfaces.BattleNet
{
    public interface IBattleNetConfig
    {
        string ApiKey { get; }
        string Locale { get; }
        string ThumbnailUrlPrefix { get; }
        BattleNetConfig.WowConfigElement WowConfig { get; }
        BattleNetConfig.Sc2ConfigElement Sc2Config { get; }
    }
}