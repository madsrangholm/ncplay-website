using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using NCPLAY.BLL.Datatypes.Riot;

namespace NCPLAY.BLL.Helpers
{
    public class EloCalculator
    {
        public enum Division
        {
            I = 4,
            II = 3,
            III = 2,
            IV = 1,
            V = 0
        }

        public enum Tier
        {
            UNRANKED = 0,
            BRONZE = 1,
            SILVER = 2,
            GOLD = 3,
            PLATINUM = 4,
            DIAMOND = 5,
            CHALLENGER = 6
        };

        public const int eloBase = 450;

        public double CalculateRiotElo(List<LeagueDto> leagues)
        {
            Contract.Requires(leagues != null, "leagues cannot be null");
            var elos = new List<double>();

            foreach (var league in leagues)
            {
                var tier = (Tier) Enum.Parse(typeof (Tier), league.tier);

                var eloTemp = (double) tier*350 + eloBase;

                var tierInt = (double) tier;

                foreach (var leagueEntry in league.entries)
                {
                    var elo = eloTemp;
                    if (league.tier != Tier.CHALLENGER.ToString())
                    {
                        var division = (Division) Enum.Parse(typeof (Division), leagueEntry.division);

                        elo += (int) division*70;
                    }

                    elo += 0.5*leagueEntry.leaguePoints;

                    if (leagueEntry.miniSeries != null &&
                        (leagueEntry.miniSeries.wins + leagueEntry.miniSeries.losses > 0))
                    {
                        elo += 20.0*
                               ((double) leagueEntry.miniSeries.wins/
                                (leagueEntry.miniSeries.wins + leagueEntry.miniSeries.losses));
                    }

                    elos.Add(elo);

                    elo = 0;
                }
            }
            return elos.Average();
        }
    }
}