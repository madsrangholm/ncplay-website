namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class WowErrorResponse : ApiErrorResponse
    {
        public string Status { get; set; }
        public string Reason { get; set; }

        public override string ToString()
        {
            return string.Format("Status: '{0}', Reason: '{1}'",
                Status,
                Reason);
        }
    }
}