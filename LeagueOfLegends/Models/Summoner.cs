using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfLegends.Models
{
    public class Summoner
    {
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
        public string GetFEmblem()
        {
            switch (FTier)
            {
                case "IRON":
                    return "https://opgg-static.akamaized.net/images/medals/iron_1.png?image=q_auto:best&v=1";
                case "BRONZE":
                    return "https://opgg-static.akamaized.net/images/medals/bronze_1.png?image=q_auto:best&v=1";
                case "SILVER":
                    return "https://opgg-static.akamaized.net/images/medals/silver_1.png?image=q_auto:best&v=1";
                case "GOLD":
                    return "https://opgg-static.akamaized.net/images/medals/gold_1.png?image=q_auto:best&v=1";
                case "PLATINUM":
                    return "https://opgg-static.akamaized.net/images/medals/platinum_1.png?image=q_auto:best&v=1";
                case "DIAMOND":
                    return "https://opgg-static.akamaized.net/images/medals/diamond_1.png?image=q_auto:best&v=1";
                case "MASTER":
                    return "https://opgg-static.akamaized.net/images/medals/master_1.png?image=q_auto:best&v=1";
                case "GRANDMASTER":
                    return "https://opgg-static.akamaized.net/images/medals/grandmaster_1.png?image=q_auto:best&v=1";
                case "CHALLENGER":
                    return "https://opgg-static.akamaized.net/images/medals/challenger_1.png?image=q_auto:best&v=1";
                default:
                    return "https://opgg-static.akamaized.net/images/medals/default.png";
            }

        }
        public string GetSDEmblem()
        {
            switch (SDTier)
            {
                case "IRON":
                    return "https://opgg-static.akamaized.net/images/medals/iron_1.png?image=q_auto:best&v=1";
                case "BRONZE":
                    return "https://opgg-static.akamaized.net/images/medals/bronze_1.png?image=q_auto:best&v=1";
                case "SILVER":
                    return "https://opgg-static.akamaized.net/images/medals/silver_1.png?image=q_auto:best&v=1";
                case "GOLD":
                    return "https://opgg-static.akamaized.net/images/medals/gold_1.png?image=q_auto:best&v=1";
                case "PLATINUM":
                    return "https://opgg-static.akamaized.net/images/medals/platinum_1.png?image=q_auto:best&v=1";
                case "DIAMOND":
                    return "https://opgg-static.akamaized.net/images/medals/diamond_1.png?image=q_auto:best&v=1";
                case "MASTER":
                    return "https://opgg-static.akamaized.net/images/medals/master_1.png?image=q_auto:best&v=1";
                case "GRANDMASTER":
                    return "https://opgg-static.akamaized.net/images/medals/grandmaster_1.png?image=q_auto:best&v=1";
                case "CHALLENGER":
                    return "https://opgg-static.akamaized.net/images/medals/challenger_1.png?image=q_auto:best&v=1";
                default:
                    return "https://opgg-static.akamaized.net/images/medals/default.png";
            }

        }
        public int MostPlayed { get; set; }
    }
}
