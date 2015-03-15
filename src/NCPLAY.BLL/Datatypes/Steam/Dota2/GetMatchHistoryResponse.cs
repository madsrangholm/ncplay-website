using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Steam
{
    public class GetMatchHistoryResponse : ApiResponse
    {
        public MatchHistory Result { get; set; }


        public string Type { get; set; }
        public bool Optional { get; set; }
        public string Description { get; set; }

        public class MatchHistory
        {
            // The number of results contained in this response
            public int num_results { get; set; }
            // The total number of results for this particular query[(total_results / num_results) = total_num_pages]
            public int total_results { get; set; }
            // The number of results left for this query[(results_remaining / num_results) = remaining_num_pages]
            public int results_remaining { get; set; }
            // An array of num_results matches
            public List<Dota2Matches> matches { get; set; }
        }

        public class Dota2Matches
        {
            // The numeric match ID
            public long match_id { get; set; }
            // The match's sequence number - the order in which matches are recorded
            public long match_seq_num { get; set; }
            // Date in UTC seconds since Jan 1, 1970 (unix time format)
            public int start_time { get; set; }
            // The type of lobby see: https://github.com/kronusme/dota2-ap...a/lobbies.json
            public int lobby_type { get; set; }
            // An array of players:
            public List<Players> players { get; set; }
        }

        public class Players
        {
            // The player's 32-bit Steam ID - will be set to "4294967295" if the player has set their account to private.
            public long account_id { get; set; }
            // An 8-bit unsigned int: if the left-most bit is set, the player was on dire.the two right-most bits represent the player slot(0-4).
            public int player_slot { get; set; }
            // The numeric ID of the hero that the player used(see below).
            public int hero_id { get; set; }
        }
    }
}