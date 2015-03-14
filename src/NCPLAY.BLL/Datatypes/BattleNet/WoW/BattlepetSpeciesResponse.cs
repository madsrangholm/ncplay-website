using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class BattlepetSpeciesResponse : ApiResponse
    {
        public int SpeciesId { get; set; }
        public int PetTypeId { get; set; }
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public bool CanBattle { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public List<BattlepetSpeciesAbility> Abilities { get; set; }

        public class BattlepetSpeciesAbility
        {
            public int Slot { get; set; }
            public int Order { get; set; }
            public int RequiredLevel { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public int Cooldown { get; set; }
            public int Rounds { get; set; }
            public int PetTypeId { get; set; }
            public bool IsPassive { get; set; }
            public bool HideHints { get; set; }
        }
    }
}