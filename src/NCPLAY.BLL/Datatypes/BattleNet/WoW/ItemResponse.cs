using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
	/// <summary>
	/// Used to encapsulate the WoW [Item API : Item] service repsponse
	/// </summary>
	public class ItemResponse : ApiResponse
    {
		/// <summary>
		/// 
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int DisenchantingSkillRank { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Icon { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int Stackable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ItemBind { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<StatItem> BonusStats { get; set; } 
		/// <summary>
		/// 
		/// </summary>
		public List<ItemSpellItem> ItemSpells { get; set; } 
	    /// <summary>
	    /// 
	    /// </summary>
	    public int BuyPrice { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ItemClass { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ItemSubClass { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ContainerSlots { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int InventoryType { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public bool Equippable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ItemLevel { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int MaxCount { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int MaxDurability { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int MinFactionId { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int MinReputation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int Quality { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int SellPrice { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int RequiredSkill { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int RequiredSkillRank { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public SourceItem ItemSource { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int BaseArmor { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public bool HasSockets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public bool IsAuctionable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int Armor { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int DisplayInfold { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string NameDescription { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string NameDescriptionColor { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public bool Upgradable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public bool HeroicTooltip { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Context { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<int> BonusLists { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public List<string> AvailableContexts { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public BonusSummaryItem BonusSummary { get; set; }  

		/// <summary>
	    /// 
	    /// </summary>
	    public class StatItem
	    {
		    /// <summary>
		    /// 
		    /// </summary>
		    public int Stat { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public int Amount { get; set; }
	    }
	    /// <summary>
	    /// 
	    /// </summary>
	    public class ItemSpellItem
	    {
		    /// <summary>
		    /// 
		    /// </summary>
		    public int SpellId { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public SpellItem Spell { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public int NCharges { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public bool Consumable { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public long CategoryId { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public string Trigger { get; set; }
		    /// <summary>
		    /// 
		    /// </summary>
		    public class SpellItem
		    {
			    /// <summary>
			    /// 
			    /// </summary>
			    public int Id { get; set; }
				/// <summary>
				/// 
				/// </summary>
				public string Name { get; set; }
				/// <summary>
				/// 
				/// </summary>
				public string Icon { get; set; }
				/// <summary>
				/// 
				/// </summary>
				public string Description { get; set; }
				/// <summary>
				/// 
				/// </summary>
				public string CastTime { get; set; }
		    }
	    }

	    /// <summary>
	    /// 
	    /// </summary>
	    public class SourceItem
	    {
		    /// <summary>
		    /// 
		    /// </summary>
		    public int SourceId { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public string SourceType { get; set; }
	    }

	    /// <summary>
	    /// 
	    /// </summary>
	    public class BonusSummaryItem
	    {
		    /// <summary>
		    /// 
		    /// </summary>
		    public List<int> DefaultBonusLists { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public List<int> ChanceBonusLists { get; set; }
			/// <summary>
			/// 
			/// </summary>
			public List<int> BonusChances { get; set; }   
	    }
    }
}
