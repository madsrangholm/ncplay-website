using System.Linq;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.BattleNet.Starcraft2;
using NCPLAY.BLL.Helpers;
using NCPLAY.BLL.Interfaces.BattleNet;

namespace NCPLAY.DAL.BattleNet
{
    public class Sc2Api : JsonBase, ISc2Api
    {
        private readonly IBattleNetConfig _config;
        public Sc2Api(IBattleNetConfig config)
        {
            _config = config;
        }
        public async Task<ProfileResponse> GetProfile(int id, string name)
        {
            var response = await JsonGetObject<ProfileResponse, Sc2ErrorResponse>(
               string.Format("{0}profile/{1}/1/{2}/?locale={3}&apikey={4}",
                   _config.Sc2Config.ApiUrl,
                   id,
                   name,
                   _config.Locale,
                   _config.ApiKey));
            response.ProfilePath = _config.Sc2Config.ProfilePathPrefix + response.ProfilePath;
            return response;
        }
        public async Task<ProfileLaddersResponse> GetProfileLadders(int id, string name)
        {
            var response = await JsonGetObject<ProfileLaddersResponse, Sc2ErrorResponse>(
               string.Format("{0}profile/{1}/1/{2}/ladders?locale={3}&apikey={4}",
                   _config.Sc2Config.ApiUrl,
                   id,
                   name,
                   _config.Locale,
                   _config.ApiKey));
            foreach (var character in response.CurrentSeason.SelectMany(ladder => ladder.Characters))
            {
                character.ProfilePath = _config.Sc2Config.ProfilePathPrefix + character.ProfilePath;
            }
            foreach (var character in response.PreviousSeason.SelectMany(ladder => ladder.Characters))
            {
                character.ProfilePath = _config.Sc2Config.ProfilePathPrefix + character.ProfilePath;
            }
            return response;
        }


        public async Task<ProfileMatchHistoryResponse> GetProfileMatchHistory(int id, string name)
        {
            return await JsonGetObject<ProfileMatchHistoryResponse, Sc2ErrorResponse>(
               string.Format("{0}profile/{1}/1/{2}/matches?locale={3}&apikey={4}",
                   _config.Sc2Config.ApiUrl,
                   id,
                   name,
                   _config.Locale,
                   _config.ApiKey));
        }


        public async Task<LadderResponse> GetLadder(int id)
        {
            var response = await JsonGetObject<LadderResponse, Sc2ErrorResponse>(
               string.Format("{0}ladder/{1}?locale={2}&apikey={3}",
                   _config.Sc2Config.ApiUrl,
                   id,
                   _config.Locale,
                   _config.ApiKey));
            foreach(var member in response.LadderMembers)
            {
                member.Character.ProfilePath = _config.Sc2Config.ProfilePathPrefix + member.Character.ProfilePath;
            }
            return response;
        }


        public async Task<AchievementsResponse> GetAchievements()
        {
            return await JsonGetObject<AchievementsResponse, Sc2ErrorResponse>(
               string.Format("{0}data/achievements?locale={1}&apikey={2}",
                   _config.Sc2Config.ApiUrl,
                   _config.Locale,
                   _config.ApiKey));
        }


        public async Task<RewardsResponse> GetRewards()
        {
            return await JsonGetObject<RewardsResponse, Sc2ErrorResponse>(
               string.Format("{0}data/rewards?locale={1}&apikey={2}",
                   _config.Sc2Config.ApiUrl,
                   _config.Locale,
                   _config.ApiKey));
        }
    }
}
