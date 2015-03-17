using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes;
using NCPLAY.BLL.Datatypes.BattleNet.WoW;
using NCPLAY.BLL.Helpers;
using NCPLAY.BLL.Interfaces.BattleNet;

namespace NCPLAY.DAL.BattleNet
{
    public class WowApi : JsonBase, IWowApi
    {
        private readonly IBattleNetConfig _config;

        /// <summary>
        /// 
        /// </summary>
        /// <param Name="config"></param>
        public WowApi(IBattleNetConfig config)
        {
            _config = config;
        }

	    public async Task<AchievementResponse> GetAchievement(int id)
        {
            var response = await JsonGetObject<AchievementResponse, WowErrorResponse>(
                string.Format("{0}achievement/{1}?locale={2}&apikey={3}",
                    _config.WowConfig.ApiUrl,
                    id,
                    _config.Locale,
                    _config.ApiKey));
            return UpdateImageUrls(response) as AchievementResponse;
        }

		public async Task<AuctionDataResponse> GetAuctionDataStatus(string realm)
        {
            var res1 = await JsonGetObject<AuctionDataResponse1, WowErrorResponse>(
                string.Format("{0}auction/data/{1}?locale={2}&apikey={3}",
                    _config.WowConfig.ApiUrl,
                    realm,
                    _config.Locale,
                    _config.ApiKey));

            return await JsonGetObject<AuctionDataResponse, WowErrorResponse>(res1.Files[0].Url);
        }

		public async Task<BattlepetAbilitiesResponse> GetBattlepetAbilities(int abilityId)
        {
            var response = await JsonGetObject<BattlepetAbilitiesResponse, WowErrorResponse>(
                string.Format("{0}battlePet/ability/{1}?locale={2}&apikey={3}",
                    _config.WowConfig.ApiUrl,
                    abilityId,
                    _config.Locale,
                    _config.ApiKey));
            return UpdateImageUrls(response) as BattlepetAbilitiesResponse;
        }

		public async Task<BattlepetSpeciesResponse> GetBattlepetSpecies(int speciesId)
        {
            return await JsonGetObject<BattlepetSpeciesResponse, WowErrorResponse>(
                string.Format("{0}battlePet/species/{1}?locale={2}&apikey={3}",
                    _config.WowConfig.ApiUrl,
                    speciesId,
                    _config.Locale,
                    _config.ApiKey));
        }

		public async Task<BattlepetStatsResponse> GetBattlepetStats(int speciesId, int level = 1, int breedId = 3,
            int qualityId = 1)
        {
            return await JsonGetObject<BattlepetStatsResponse, WowErrorResponse>(
                string.Format("{0}battlePet/stats/{1}?level={2}&breedId={3}&qualityId={4}&locale={5}&apikey={6}",
                    _config.WowConfig.ApiUrl,
                    speciesId,
                    level,
                    breedId,
                    qualityId,
                    _config.Locale,
                    _config.ApiKey));
        }

		public async Task<ChallengeResponse> GetChallengeLeaderboardRealm(string realm)
        {
            var response = await JsonGetObject<ChallengeResponse, WowErrorResponse>(
                string.Format("{0}challenge/{1}?locale={2}&apikey={3}",
                    _config.WowConfig.ApiUrl,
                    realm,
                    _config.Locale,
                    _config.ApiKey));
            return UpdateImageUrls(response) as ChallengeResponse;
        }

        public async Task<ChallengeResponse> GetChallengeLeaderboardRegion()
        {
            var response = await JsonGetObject<ChallengeResponse, WowErrorResponse>(
                string.Format("{0}challenge/region?locale={1}&apikey={2}",
                    _config.WowConfig.ApiUrl,
                    _config.Locale,
                    _config.ApiKey));
            return UpdateImageUrls(response) as ChallengeResponse;
        }

		public async Task<CharacterProfileResponse> GetCharacterProfile(string realm, string characterName,
            IEnumerable<CharacterProfileResponse.CharacterProfileField> fields = null)
        {
            var response = await JsonGetObject<CharacterProfileResponse, WowErrorResponse>(
                string.Format("{0}character/{1}/{2}?{3}locale={4}&apikey={5}",
                    _config.WowConfig.ApiUrl,
                    realm,
                    characterName,
                    (fields != null && fields.Any())
                        ? "fields=" + GenerateFieldsString(fields) + "&"
                        : String.Empty,
                    _config.Locale,
                    _config.ApiKey));
            return UpdateImageUrls(response) as CharacterProfileResponse;
        }

		public async Task<ItemResponse> GetItem(int id)
	    {
			var response = await JsonGetObject<ItemResponse, WowErrorResponse>(
				string.Format("{0}item/{1}?locale={2}&apikey={3}",
					_config.WowConfig.ApiUrl,
					id,
					_config.Locale,
					_config.ApiKey));
		    response.Icon = UpdateIconUrl(response.Icon);
		    foreach (var itemSpell in response.ItemSpells)
		    {
			    if (itemSpell.Spell != null && !string.IsNullOrEmpty(itemSpell.Spell.Icon))
			    {
					itemSpell.Spell.Icon = UpdateIconUrl(itemSpell.Spell.Icon);
				}	
		    }
		    return response;
	    }

	    #region Helper functions

        private static string GenerateFieldsString(IEnumerable<CharacterProfileResponse.CharacterProfileField> fields)
        {
            var result = string.Empty;
            if (fields == null || !fields.Any()) return result;
            foreach (var f in fields)
            {
                result += f.ToString().ToPascalCase() + ",";
            }
            //remove last comma
            return result.Substring(0, result.Length - 1);
        }

        private string UpdateIconUrl(string uri)
        {
            return _config.WowConfig.IconUrlPrefix + uri + _config.WowConfig.IconFileExtension;
        }

        private string UpdateBackgroundImageUrl(string uri)
        {
            return _config.WowConfig.BackgroundImageUrlPrefix + uri + _config.WowConfig.BackgroundImageFileExtension;
        }

        private string UpdateThumbnailUrl(string uri)
        {
            return _config.ThumbnailUrlPrefix + uri;
        }

        private ApiResponse UpdateImageUrls(ApiResponse response)
        {
            if (response is AchievementResponse)
            {
                var r = response as AchievementResponse;
                r.Icon = UpdateIconUrl(r.Icon);
	            foreach (var a in r.RewardItems.Where(a => !string.IsNullOrEmpty(a.Icon)))
	            {
		            a.Icon = UpdateIconUrl(a.Icon);
	            }
                return r;
            }
            if (response is BattlepetAbilitiesResponse)
            {
                var r = response as BattlepetAbilitiesResponse;
                r.Icon = UpdateIconUrl(r.Icon);
                return r;
            }
            if (response is BattlepetSpeciesResponse)
            {
                var r = response as BattlepetSpeciesResponse;
                r.Icon = UpdateIconUrl(r.Icon);
                return r;
            }
            if (response is ChallengeResponse)
            {
                var r = response as ChallengeResponse;
                foreach(var m in r.Challenge.SelectMany(c => c.Groups.SelectMany(g => g.Members)))
                {
                    if (m.Character != null)
                    {
                        if (m.Character.Spec != null)
                        {
                            m.Character.Spec.Icon = UpdateIconUrl(m.Character.Spec.Icon);
                            m.Character.Spec.BackgroundImage = UpdateBackgroundImageUrl(m.Character.Spec.BackgroundImage);
                        }
                        m.Character.Thumbnail = UpdateThumbnailUrl(m.Character.Thumbnail);
                    }
                    if (m.Spec != null)
                    {
                        m.Spec.BackgroundImage = UpdateBackgroundImageUrl(m.Spec.BackgroundImage);
                        m.Spec.Icon = UpdateIconUrl(m.Spec.Icon);
                    }
                }
                return r;
            }
            if (response is CharacterProfileResponse)
            {
                var r = response as CharacterProfileResponse;
                r.Thumbnail = UpdateThumbnailUrl(r.Thumbnail);
                if (r.Feed != null)
                {
	                foreach (var a in r.Feed.Where(x => x.Achievement != null).Select(x => x.Achievement))
	                {
		                a.Icon = UpdateIconUrl(a.Icon);
	                }
                }
                if (r.Items != null)
                {
                    if (r.Items.Head != null)
                    {
                        r.Items.Head.Icon = UpdateIconUrl(r.Items.Head.Icon);
                    }
                    if (r.Items.Neck != null)
                    {
                        r.Items.Neck.Icon = UpdateIconUrl(r.Items.Neck.Icon);
                    }
                    if (r.Items.Shoulder != null)
                    {
                        r.Items.Shoulder.Icon = UpdateIconUrl(r.Items.Shoulder.Icon);
                    }
                    if (r.Items.Back != null)
                    {
                        r.Items.Back.Icon = UpdateIconUrl(r.Items.Back.Icon);
                    }
                    if (r.Items.Chest != null)
                    {
                        r.Items.Chest.Icon = UpdateIconUrl(r.Items.Chest.Icon);
                    }
                    if (r.Items.Shirt != null)
                    {
                        r.Items.Shirt.Icon = UpdateIconUrl(r.Items.Shirt.Icon);
                    }
                    if (r.Items.Wrist != null)
                    {
                        r.Items.Wrist.Icon = UpdateIconUrl(r.Items.Wrist.Icon);
                    }
                    if (r.Items.Hands != null)
                    {
                        r.Items.Hands.Icon = UpdateIconUrl(r.Items.Hands.Icon);
                    }
                    if (r.Items.Waist != null)
                    {
                        r.Items.Waist.Icon = UpdateIconUrl(r.Items.Waist.Icon);
                    }
                    if (r.Items.Legs != null)
                    {
                        r.Items.Legs.Icon = UpdateIconUrl(r.Items.Legs.Icon);
                    }
                    if (r.Items.Feet != null)
                    {
                        r.Items.Feet.Icon = UpdateIconUrl(r.Items.Feet.Icon);
                    }
                    if (r.Items.Finger1 != null)
                    {
                        r.Items.Finger1.Icon = UpdateIconUrl(r.Items.Finger1.Icon);
                    }
                    if (r.Items.Finger2 != null)
                    {
                        r.Items.Finger2.Icon = UpdateIconUrl(r.Items.Finger2.Icon);
                    }
                    if (r.Items.Trinket1 != null)
                    {
                        r.Items.Trinket1.Icon = UpdateIconUrl(r.Items.Trinket1.Icon);
                    }
                    if (r.Items.Trinket2 != null)
                    {
                        r.Items.Trinket2.Icon = UpdateIconUrl(r.Items.Trinket2.Icon);
                    }
                    if (r.Items.MainHand != null)
                    {
                        r.Items.MainHand.Icon = UpdateIconUrl(r.Items.MainHand.Icon);
                    }
                    if (r.Items.OffHand != null)
                    {
                        r.Items.OffHand.Icon = UpdateIconUrl(r.Items.OffHand.Icon);
                    }
                }
                if (r.Mounts != null)
                {
	                foreach (var c in r.Mounts.Collected)
	                {
		                c.Icon = UpdateIconUrl(c.Icon);
	                }
                }
                if (r.Pets != null)
                {
	                foreach (var p in r.Pets.Collected)
	                {
		                p.Icon = UpdateIconUrl(p.Icon);
	                }
                }
                if (r.Talents != null)
                {
                    foreach(var t in r.Talents)
                    {
                        if (t.Spec != null)
                        {
                            t.Spec.BackgroundImage = UpdateBackgroundImageUrl(t.Spec.BackgroundImage);
                            t.Spec.Icon = UpdateIconUrl(t.Spec.Icon);
                        }
                        if (t.Glyphs != null)
                        {
                            if (t.Glyphs.Major != null)
                            {
	                            foreach (var g in t.Glyphs.Major)
	                            {
		                            g.Icon = UpdateIconUrl(g.Icon);
	                            }
                            }
                            if (t.Glyphs.Minor != null)
                            {
	                            foreach (var g in t.Glyphs.Minor)
	                            {
		                            g.Icon = UpdateIconUrl(g.Icon);
	                            }
                            }
                        }
                        if (t.Talents != null)
                        {
	                        foreach (var s in t.Talents.Where(x => x.Spell != null).Select(x => x.Spell))
	                        {
		                        s.Icon = UpdateIconUrl(s.Icon);
	                        }
                        }
                    }
                }
                if (r.Audit != null)
                {
                    if (r.Audit.RecommendedBeltBuckle != null)
                    {
                        r.Audit.RecommendedBeltBuckle.Icon = UpdateIconUrl(r.Audit.RecommendedBeltBuckle.Icon);
	                    foreach (var i in r.Audit.RecommendedBeltBuckle.ItemSpells)
	                    {
		                    i.Spell.Icon = UpdateIconUrl(i.Spell.Icon);
	                    }
                    }
                    if (r.Audit.RecommendedJewelcrafterGem != null)
                    {
                        r.Audit.RecommendedJewelcrafterGem.Icon = UpdateIconUrl(r.Audit.RecommendedJewelcrafterGem.Icon);
	                    foreach (var i in r.Audit.RecommendedJewelcrafterGem.ItemSpells)
	                    {
		                    i.Spell.Icon = UpdateIconUrl(i.Spell.Icon);
	                    }
                    }
                }

                return r;
            }
            return response;
        }

        #endregion

    }
}