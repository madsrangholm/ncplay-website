using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCPLAY.BLL.Datatypes.BattleNet.Starcraft2
{
    public class ProfileMatchHistoryResponse : ApiResponse
    {
        public List<MatchItem> Matches { get; set; }

        public class MatchItem
        {
            public string Map { get; set; }
            public string Type { get; set; }
            public Sc2MatchResult Decision { get; set; }
            public Sc2GameSpeed Speed { get; set; }
            public long Date { get; set; }
        }
    }
}
