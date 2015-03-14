namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class BattlepetStatsResponse : ApiResponse
    {
        public int SpeciesId { get; set; }
        public int BreedId { get; set; }
        public int PetQualityId { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
    }
}