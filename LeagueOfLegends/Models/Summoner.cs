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
        public int FWins { get; set; }
        public int FLosses { get; set; }
        public string FTier { get; set; }
        public string FRank { get; set; }
        public int FLP { get; set; }
        public int SDWins { get; set; }
        public int SDLosses { get; set; }
        public string SDTier { get; set; }
        public string SDRank { get; set; }
        public int SDLP { get; set; }
    }
}
