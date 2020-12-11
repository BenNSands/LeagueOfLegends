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
        public int FWins { get; set; } = 0;
        public int FLosses { get; set; } = 0;
        public string FTier { get; set; } = "Unranked";
        public string FRank { get; set; }
        public int FLP { get; set; } = 0;
        public int SDWins { get; set; } = 0;
        public int SDLosses { get; set; } = 0;
        public string SDTier { get; set; } = "Unranked";
        public string SDRank { get; set; }
        public int SDLP { get; set; } = 0;
        public string GetFCSSColor() 
        {
            switch (FTier)
            {
                case "IRON":
                    return "#8C8583";
                case "BRONZE":
                    return "#985734";
                case "SILVER":
                    return "#87A0A8";
                case "GOLD":
                   return "#DEA43C";
                case "PLATINUM":
                    return "#3A7A79";
                case "DIAMOND":
                    return "#2A2070";
                case "MASTER":
                    return "#D61FE1";
                case "GRANDMASTER":
                    return "#FF2827";
                case "CHALLENGER":
                    return "#64FFFF";
                default:
                    return "#cccccc";
            }
        }
        public string GetSDCSSColor()
        {
            switch (SDTier)
            {
                case "IRON":
                    return "#8C8583";
                case "BRONZE":
                    return "#985734";
                case "SILVER":
                    return "#87A0A8";
                case "GOLD":
                    return "#DEA43C";
                case "PLATINUM":
                    return "#3A7A79";
                case "DIAMOND":
                    return "#2A2070";
                case "MASTER":
                    return "#D61FE1";
                case "GRANDMASTER":
                    return "#FF2827";
                case "CHALLENGER":
                    return "#64FFFF";
                default:
                    return "#cccccc";
            }
        }
       
        
    }
}
