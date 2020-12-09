using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfLegends.Models
{
    public class Summoner
    {
        /* "leagueId": "f614ff48-e79d-4f78-af76-c8a733533a17",
        "queueType": "RANKED_SOLO_5x5",
        "tier": "GOLD",
        "rank": "III",
        "summonerId": "sr4qsPjllF0-a7HrxdO85c4Lp2VDKEHoDwQvVUTTRjzbM6k",
        "summonerName": "Dopas Son",
        "leaguePoints": 47,
        "wins": 318,
        "losses": 327,
        "veteran": false,
        "inactive": false,
        "freshBlood": false,
        "hotStreak": false*/

        public string SummonerID { get; set; }
        public string SummonerName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
    }
}
