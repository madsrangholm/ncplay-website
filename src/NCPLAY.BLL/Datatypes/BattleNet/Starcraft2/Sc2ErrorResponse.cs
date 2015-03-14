
namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class Sc2ErrorResponse : ApiErrorResponse
    {
        public string Status { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return string.Format("Status: {0}, Code: {1}, Message: {2}",
                Status,
                Code,
                Message);
        }
    }
}
