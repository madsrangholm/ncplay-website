using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class CharacterProfileResponse : ApiResponse
    {
        public enum CharacterProfileField
        {
            Achievements,
            Appearance,
            Feed,
            Guild,
            HunterPets,
            Items,
            Mounts,
            Pets,
            PetSlots,
            Progression,
            Pvp,
            Quests,
            Reputation,
            Stats,
            Talents,
            Titles,
            Audit
        }

        public long LastModified { get; set; }

        public string Name { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public string Thumbnail { get; set; }
        public string CalcClass { get; set; }
        public int TotalHonorableKills { get; set; }
        public ProfileAchievements Achievements { get; set; }
        public ProfileAppearance Appearance { get; set; }
        public List<ProfileFeed> Feed { get; set; }
        public ProfileGuild Guild { get; set; }
        public ProfileItem Items { get; set; }
        public ProfileMounts Mounts { get; set; }
        public ProfilePets Pets { get; set; }
        public ProfileProgression Progression { get; set; }
        public ProfilePvP PvP { get; set; }
        public List<int> Quests { get; set; }
        public List<ProfileReputation> Reputation { get; set; }
        public ProfileStats Stats { get; set; }
        public List<ProfileTalent> Talents { get; set; }
        public List<ProfileTitle> Titles { get; set; }
        public ProfileAudit Audit { get; set; }
        public List<ProfilePetSlot> PetSlots { get; set; }

        public class ProfileAchievements
        {
            public List<int> AchievementsCompleted { get; set; }
            public List<long> AchievementsCompletedTimestamp { get; set; }
            public List<int> Criteria { get; set; }
            public List<long> CriteriaCreated { get; set; }
            public List<long> CriteriaQuantity { get; set; }
            public List<long> CriteriaTimestamp { get; set; }
        }

        public class ProfileAppearance
        {
            public int FaceVariation { get; set; }
            public int SkinColor { get; set; }
            public int HairVariation { get; set; }
            public int HairColor { get; set; }
            public int FeatureVariation { get; set; }
            public bool ShowHelm { get; set; }
            public bool ShowCloak { get; set; }
        }

        public class ProfileAudit
        {
            public int NumberOfIssues { get; set; }
            public Dictionary<string, int> Slots { get; set; }
            public int EmptyGlyphSlots { get; set; }
            public int UnspentTalentPoints { get; set; }
            public bool NoSpec { get; set; }
            public Dictionary<string, int> UnenchantedItems { get; set; }
            public int EmptySockets { get; set; }
            public Dictionary<string, int> ItemsWithEmptySockets { get; set; }
            public int AppropriateArmorType { get; set; }
            public Dictionary<string, int> InappropriateArmorType { get; set; }
            public int LowLevelThreshold { get; set; }
            public Dictionary<string, int> MissingExtraSockets { get; set; }
            public RecommendedItem RecommendedBeltBuckle { get; set; }
            public Dictionary<string, int> MissingBlacksmithSockets { get; set; }
            public Dictionary<string, int> MissingEnchanterEnchants { get; set; }
            public Dictionary<string, int> MissingEngineerEnchants { get; set; }
            public Dictionary<string, int> MissingScribeEnchants { get; set; }
            public int NMissingJewelcrafterGems { get; set; }
            public RecommendedItem RecommendedJewelcrafterGem { get; set; }
            public Dictionary<string, int> MissingLeatherworkerEnchants { get; set; }

            public class RecommendedItem
            {
                public int Id { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public string Icon { get; set; }
                public int Stackable { get; set; }
                public int ItemBind { get; set; }

                /// <summary>
                ///     Unconfirmed datatype
                /// </summary>
                public List<int> BonusStats { get; set; }

                public List<ItemSpell> ItemSpells { get; set; }
                public int BuyPrice { get; set; }
                public int ItemClass { get; set; }
                public int ItemSubClass { get; set; }
                public int ContainerSlots { get; set; }
                public int InventoryType { get; set; }
                public bool Equippable { get; set; }
                public int ItemLevel { get; set; }
                public int MaxCount { get; set; }
                public int MaxDurability { get; set; }
                public int MinFactionId { get; set; }
                public int MinReputation { get; set; }
                public int Quality { get; set; }
                public int SellPrice { get; set; }
                public int RequiredSkill { get; set; }
                public int RequiredLevel { get; set; }
                public int RequiredSkillRank { get; set; }
                public ItemSrc ItemSource { get; set; }
                public int BaseArmor { get; set; }
                public bool HasSockets { get; set; }
                public bool IsAuctionable { get; set; }
                public int Armor { get; set; }
                public int DisplayInfold { get; set; }
                public string NameDescription { get; set; }
                public string NameDescriptionColor { get; set; }
                public bool Upgradable { get; set; }
                public bool HeroicTooltip { get; set; }
                public string Context { get; set; }

                /// <summary>
                ///     Datatype unconfirmed
                /// </summary>
                public List<int> BonusLists { get; set; }

                public List<string> AvailableContexts { get; set; }
                // Ikke helt sikker på den her def
                public Dictionary<string, List<string>> BonusSummary { get; set; }

                public class ItemSpell
                {
                    public int Id { get; set; }
                    public SpellItem Spell { get; set; }
                    public int NCharges { get; set; }
                    public bool Consumable { get; set; }
                    public int CategoryId { get; set; }
                    public string Trigger { get; set; }

                    public class SpellItem
                    {
                        public int Id { get; set; }
                        public string Name { get; set; }
                        public string Icon { get; set; }
                        public string Description { get; set; }
                        public string CastTime { get; set; }
                    }
                }

                public class ItemSrc
                {
                    public int SourceId { get; set; }
                    public string SourceType { get; set; }
                }
            }
        }

        public class ProfileFeed
        {
            public AchievementItem Achievement { get; set; }
            public string Type { get; set; }
            public long Timestamp { get; set; }
            public bool FeatOfStrength { get; set; }
            public int ItemId { get; set; }
            public CriterionItem Criteria { get; set; }
            public long Quantity { get; set; }

            public class AchievementItem
            {
                public bool AccountWide { get; set; }
                public string Description { get; set; }
                public int FactionId { get; set; }
                public string Icon { get; set; }
                public int Id { get; set; }
                public int Points { get; set; }
                public string Title { get; set; }

                /// <summary>
                ///     Unknown datatype
                /// </summary>
                public List<string> RewardItems { get; set; }

                public List<CriterionItem> Criteria { get; set; }
            }

            public class CriterionItem
            {
                public int Id { get; set; }
                public string Description { get; set; }
                public int OrderIndex { get; set; }
                public int Max { get; set; }
            }
        }

        public class ProfileGuild
        {
            public string Name { get; set; }
            public string Realm { get; set; }
            public string BattleGroup { get; set; }
            public int Members { get; set; }
            public int AchievementPoints { get; set; }
            public EmblemItem Emblem { get; set; }

            public class EmblemItem
            {
                public int Icon { get; set; }
                public string IconColor { get; set; }
                public int Border { get; set; }
                public string BorderColor { get; set; }
                public string BackgroundColor { get; set; }
            }
        }

        public class ProfileItem
        {
            public int AverageItemLevel { get; set; }
            public int AverageItemLevelEquipped { get; set; }
            public BodyPart Head { get; set; }
            public BodyPart Neck { get; set; }
            public BodyPart Shoulder { get; set; }
            public BodyPart Back { get; set; }
            public BodyPart Chest { get; set; }
            public BodyPart Shirt { get; set; }
            public BodyPart Wrist { get; set; }
            public BodyPart Hands { get; set; }
            public BodyPart Waist { get; set; }
            public BodyPart Legs { get; set; }
            public BodyPart Feet { get; set; }
            public BodyPart Finger1 { get; set; }
            public BodyPart Finger2 { get; set; }
            public BodyPart Trinket1 { get; set; }
            public BodyPart Trinket2 { get; set; }
            public BodyPart MainHand { get; set; }
            public BodyPart OffHand { get; set; }

            public class BodyPart
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Icon { get; set; }
                public int Quality { get; set; }
                public int ItemLevel { get; set; }
                public TooltipParamItem TooltipParams { get; set; }
                public List<StatItem> Stats { get; set; }
                public int Armor { get; set; }
                public string Context { get; set; }
                public List<int> BonusLists { get; set; }

	            public class TooltipParamItem
	            {
		            public List<int> Set { get; set; }
					public int TransmogItem { get; set; } 
	            }
                public class StatItem
                {
                    public int Stat { get; set; }
                    public int Amount { get; set; }
                }
            }
        }

        public class ProfileMounts
        {
            public int NumCollected { get; set; }
            public int NumNotCollected { get; set; }
            public List<CollectItem> Collected { get; set; }

            public class CollectItem
            {
                public string Name { get; set; }
                public int SpellId { get; set; }
                public int CreatureId { get; set; }
                public int ItemId { get; set; }
                public int QualityId { get; set; }
                public string Icon { get; set; }
                public bool IsGround { get; set; }
                public bool IsFlying { get; set; }
                public bool IsAquatic { get; set; }
                public bool IsJumping { get; set; }
            }
        }

        public class ProfilePetSlot
        {
            public int Slot { get; set; }
            public string BattlePetGuid { get; set; }
            public bool IsEmpty { get; set; }
            public bool IsLocked { get; set; }
            public List<int> Abilities { get; set; }
        }

        public class ProfilePets
        {
            public int NumCollected { get; set; }
            public int NumNotCollected { get; set; }
            public List<CollectItem> Collected { get; set; }

            public class CollectItem
            {
                public string Name { get; set; }
                public int SpellId { get; set; }
                public int CreatureId { get; set; }
                public int ItemId { get; set; }
                public int QualityId { get; set; }
                public string Icon { get; set; }
                public Dictionary<string, int> Stats { get; set; }
                public string BattlePetGuid { get; set; }
                public bool IsFavorite { get; set; }
                public bool IsFirstAbilitySlotSelected { get; set; }
                public bool IsSecondAbilitySlotSelected { get; set; }
                public bool IsThirdAbilitySlotSelected { get; set; }
                public string CreatureName { get; set; }
                public bool CanBattle { get; set; }
            }
        }

        public class ProfileProgression
        {
            public List<Raid> Raids { get; set; }

            public class Raid
            {
                public string Name { get; set; }
                public int Lfr { get; set; }
                public int Normal { get; set; }
                public int Heroic { get; set; }
                public int Mythic { get; set; }
                public int Id { get; set; }
                public List<Boss> Bosses { get; set; }

                public class Boss
                {
                    public int Id { get; set; }
                    public string Name { get; set; }
                    public int NormalKills { get; set; }
                    public long NormalTimestamp { get; set; }
                }
            }
        }

        public class ProfilePvP
        {
            public Dictionary<string, Bracket> Brackets { get; set; }

            public class Bracket
            {
                public string Slug { get; set; }
                public int Rating { get; set; }
                public int WeeklyPlayed { get; set; }
                public int WeeklyWon { get; set; }
                public int WeeklyLost { get; set; }
                public int SeasonPlayed { get; set; }
                public int SeasonWon { get; set; }
                public int SeasonLost { get; set; }
            }
        }

        public class ProfileReputation
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Standing { get; set; }
            public int Value { get; set; }
            public int Max { get; set; }
        }

        public class ProfileStats
        {
            public int Health { get; set; }
            public string PowerType { get; set; }
            public int Power { get; set; }
            public int Str { get; set; }
            public int Agi { get; set; }
            public int Int { get; set; }
            public int Sta { get; set; }
            public double SpeedRating { get; set; }
            public double SpeedRatingBonus { get; set; }
            public double Crit { get; set; }
            public double CritRating { get; set; }
            public double Haste { get; set; }
            public int HasteRating { get; set; }
            public double HasteRatingPercent { get; set; }
            public double Mastery { get; set; }
            public int MasteryRating { get; set; }
            public int Spr { get; set; }
            public int BonusArmor { get; set; }
            public double MultiStrike { get; set; }
            public double MultiStrikeRating { get; set; }
            public double MultiStrikeRatingBonus { get; set; }
            public double Leech { get; set; }
            public double LeechRating { get; set; }
            public double LeechRatingBonus { get; set; }
            public int Versatility { get; set; }
            public double VersatilityDamageDoneBonus { get; set; }
            public double VersatilityHealingDoneBonus { get; set; }
            public double VersatilityDamageTakenBonus { get; set; }
            public double AvoidanceRating { get; set; }
            public double AvoidanceRatingBonus { get; set; }
            public int SpellPower { get; set; }
            public int SpellPen { get; set; }
            public double SpellCrit { get; set; }
            public int SpellCritRating { get; set; }
            public double Mana5 { get; set; }
            public double Mana5Combat { get; set; }
            public int Armor { get; set; }
            public double Dodge { get; set; }
            public int DodgeRating { get; set; }
            public double Parry { get; set; }
            public int ParryRating { get; set; }
            public double Block { get; set; }
            public int BlockRating { get; set; }
            public double MainHandDmgMin { get; set; }
            public double MainHandDmgMax { get; set; }
            public double MainHandSpeed { get; set; }
            public double MainHandDps { get; set; }
            public double OffHandDmgMin { get; set; }
            public double OffHandDmgMax { get; set; }
            public double OffHandSpeed { get; set; }
            public double OffHandDps { get; set; }
            public double RangedDmgMin { get; set; }
            public double RangedDmgMax { get; set; }
            public double RangedSpeed { get; set; }
            public double RangedDps { get; set; }
            public int AttackPower { get; set; }
            public int RangedAttackPower { get; set; }
        }

        public class ProfileTalent
        {
            public string CalcGlyph { get; set; }
            public string CalcSpec { get; set; }
            public string CalcTalent { get; set; }
            public List<TalentItem> Talents { get; set; }
            public Glyph Glyphs { get; set; }
            public SpecItem Spec { get; set; }

            public class Glyph
            {
                public List<GlyphItem> Major { get; set; }
                public List<GlyphItem> Minor { get; set; }

                public class GlyphItem
                {
                    public int Glyph { get; set; }
                    public int Item { get; set; }
                    public string Name { get; set; }
                    public string Icon { get; set; }
                }
            }

            public class SpecItem
            {
                public string BackgroundImage { get; set; }
                public string Description { get; set; }
                public string Icon { get; set; }
                public string Name { get; set; }
                public int Order { get; set; }
                public string Role { get; set; }
            }

            public class TalentItem
            {
                public int Tier { get; set; }
                public int Column { get; set; }
                public SpellItem Spell { get; set; }

                public class SpellItem
                {
                    public int Id { get; set; }
                    public string Name { get; set; }
                    public string Icon { get; set; }
                    public string Description { get; set; }
                    public string Range { get; set; }
                    public string PowerCost { get; set; }
                    public string CastTime { get; set; }
                    public string Cooldown { get; set; }
                }
            }
        }

        public class ProfileTitle
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}