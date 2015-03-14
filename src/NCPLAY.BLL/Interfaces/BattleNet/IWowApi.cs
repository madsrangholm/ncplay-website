using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using NCPLAY.BLL.Datatypes.BattleNet.WoW;

namespace NCPLAY.BLL.Interfaces.BattleNet
{
	[ContractClassFor(typeof(IWowApi))]
	internal abstract class WowApiContracts : IWowApi
	{
		public Task<AchievementResponse> GetAchievement(int id)
		{
			Contract.Requires(0 <= id, "id must be positive");
			Contract.Ensures(Contract.Result<Task<AchievementResponse>>().Result != null);
			return default(Task<AchievementResponse>);
		}

		public Task<AuctionDataResponse> GetAuctionDataStatus(string realm)
		{
			Contract.Requires(!string.IsNullOrEmpty(realm), "realm cant be null or empty.");
			Contract.Ensures(Contract.Result<Task<AuctionDataResponse>>().Result != null);
			return default(Task<AuctionDataResponse>);
		}

		public Task<BattlepetAbilitiesResponse> GetBattlepetAbilities(int abilityId)
		{
			Contract.Requires(0 <= abilityId, "abilityId must be positive");
			Contract.Ensures(Contract.Result<Task<BattlepetAbilitiesResponse>>().Result != null);
			return default(Task<BattlepetAbilitiesResponse>);
		}

		public Task<BattlepetSpeciesResponse> GetBattlepetSpecies(int speciesId)
		{
			Contract.Requires(0 <= speciesId, "speciesId must be positive");
			Contract.Ensures(Contract.Result<Task<BattlepetSpeciesResponse>>().Result != null);
			return default(Task<BattlepetSpeciesResponse>);
		}

		public Task<BattlepetStatsResponse> GetBattlepetStats(int speciesId, int level = 1, int breedId = 3,
			int qualityId = 1)
		{
			Contract.Requires(0 <= speciesId, "speciesId must be positive");
			Contract.Requires(0 <= level && level <= 25, "level must be between 0 and 25");
			Contract.Requires(0 <= breedId, "breedId must be positive");
			Contract.Requires(0 <= qualityId && qualityId <= 6, "qualityId must be between 0 and 6");
			Contract.Ensures(Contract.Result<Task<BattlepetStatsResponse>>().Result != null);
			return default(Task<BattlepetStatsResponse>);
		}


		public Task<ChallengeResponse> GetChallengeLeaderboardRealm(string realm)
		{
			Contract.Requires(!string.IsNullOrEmpty(realm), "realm cant be null or empty.");
			Contract.Ensures(Contract.Result<Task<ChallengeResponse>>().Result != null);
			return default(Task<ChallengeResponse>);
		}


		public Task<ChallengeResponse> GetChallengeLeaderboardRegion()
		{
			Contract.Ensures(Contract.Result<Task<ChallengeResponse>>().Result != null);
			return default(Task<ChallengeResponse>);
		}

		public Task<CharacterProfileResponse> GetCharacterProfile(string realm, string characterName,
			IEnumerable<CharacterProfileResponse.CharacterProfileField> fields = null)
		{
			Contract.Requires(!string.IsNullOrEmpty(realm), "realm cant be null or empty.");
			Contract.Requires(!string.IsNullOrEmpty(characterName), "characterName cant be null or empty.");
			Contract.Ensures(Contract.Result<Task<CharacterProfileResponse>>().Result != null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Achievements)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Achievements == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Appearance)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Appearance == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Feed)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Feed == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Guild)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Guild == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.HunterPets)) ^
								 Contract.Result<Task<CharacterProfileResponse>>().Result == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Items)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Items == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Mounts)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Mounts == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Pets)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Pets == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.PetSlots)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.PetSlots == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Progression)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Progression == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Pvp)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.PvP == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Quests)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Quests == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Reputation)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Reputation == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Stats)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Stats == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Talents)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Talents == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Titles)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Titles == null);
			Contract.Ensures(
				(fields != null && fields.Any(x => x == CharacterProfileResponse.CharacterProfileField.Audit)) ^
				Contract.Result<Task<CharacterProfileResponse>>().Result.Audit == null);
			return default(Task<CharacterProfileResponse>);
		}

		public Task<ItemResponse> GetItem(int id)
		{
			Contract.Requires(0 <= id, "speciesId must be positive");
			Contract.Ensures(Contract.Result<Task<ItemResponse>>().Result == null);
			return default(Task<ItemResponse>);
		}
	}

    /// <summary>
    ///     Interface for the World of Warcraft API
    /// </summary>
    [ContractClass(typeof(WowApiContracts))]
	public interface IWowApi
    {
        /// <summary>
        ///     This provides data about an individual achievement.
        /// </summary>
        /// <param name="id">The ID of the achievement to retrieve.</param>
        /// <returns></returns>
        Task<AchievementResponse> GetAchievement(int id);

        /// <summary>
        ///     Auction APIs currently provide rolling batches of data about current auctions. Fetching auction dumps is a two step
        ///     process that involves checking a per-realm index file to determine if a recent dump has been generated and then
        ///     fetching the most recently generated dump file if necessary.
        ///     This API resource provides a per-realm list of recently generated auction house data dumps.
        /// </summary>
        /// <param name="realm">The realm being requested.</param>
        /// <returns></returns>
        Task<AuctionDataResponse> GetAuctionDataStatus(string realm);

        /// <summary>
        ///     This provides data about a individual battle pet ability ID. We do not provide the tooltip for the ability yet. We
        ///     are working on a better way to provide this since it depends on your pet's species, level and quality rolls.
        /// </summary>
        /// <param name="abilityId">The ID of the ability you want to retrieve.</param>
        /// <returns></returns>
        Task<BattlepetAbilitiesResponse> GetBattlepetAbilities(int abilityId);

        /// <summary>
        ///     This provides the data about an individual pet species. The species IDs can be found your character profile using
        ///     the options pets field. Each species also has data about what it's 6 abilities are.
        /// </summary>
        /// <param name="speciesId">The species you want to retrieve data on.</param>
        /// <returns></returns>
        Task<BattlepetSpeciesResponse> GetBattlepetSpecies(int speciesId);

        /// <summary>
        ///     Retrieve detailed information about a given species of pet.
        /// </summary>
        /// <param name="speciesId">
        ///     The pet's species ID. This can be found by querying a users' list of pets via the Character
        ///     Profile API.
        /// </param>
        /// <param name="level">The pet's level. Pet levels max out at 25. If omitted the API assumes a default value of 1.</param>
        /// <param name="breedId">
        ///     The pet's breed. Retrievable via the Character Profile API. If omitted the API assumes a default
        ///     value of 3.
        /// </param>
        /// <param name="qualityId">
        ///     The pet's quality. Retrievable via the Character Profile API. Pet quality can rage from 0 to 6
        ///     (0 is poor quality and 6 is legendary). If omitted the API will assume a default value of 1.
        /// </param>
        /// <returns></returns>
        Task<BattlepetStatsResponse> GetBattlepetStats(int speciesId, int level = 1, int breedId = 3, int qualityId = 1);


        /// <summary>
        ///     The data in this request has data for all 9 challenge mode maps (currently). The map field includes the current
        ///     medal times for each dungeon. Inside each ladder we provide data about each character that was part of each run.
        ///     The character data includes the current cached spec of the character while the member field includes the spec of
        ///     the character during the challenge mode run.
        /// </summary>
        /// <param name="realm">The realm being requested.</param>
        /// <returns></returns>
        Task<ChallengeResponse> GetChallengeLeaderboardRealm(string realm);

        /// <summary>
        ///     The region leaderboard has the exact same data format as the realm leaderboards except there is no realm field. It
        ///     is simply the top 100 results gathered for each map for all of the available realm leaderboards in a region.
        /// </summary>
        /// <returns></returns>
        Task<ChallengeResponse> GetChallengeLeaderboardRegion();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="realm">The realm being requested.</param>
		/// <param name="characterName">The name of the character you want to retrieve.</param>
		/// <param name="fields">Specifies what data you want to retrieve.</param>
		/// <returns></returns>
		Task<CharacterProfileResponse> GetCharacterProfile(string realm, string characterName,
            IEnumerable<CharacterProfileResponse.CharacterProfileField> fields = null);

		/// <summary>
		/// The item API provides detailed item information. This includes item set information if this item is part of a set.
		/// </summary>
		/// <param name="id">Unique ID of the item being requested.</param>
		/// <returns></returns>
		Task<ItemResponse> GetItem(int id);
    }
}