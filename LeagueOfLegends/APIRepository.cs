using LeagueOfLegends.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    public static class APIRepository
    {
        public static Summoner GetSummonerID(string summonerName)
        {
            var api = System.IO.File.ReadAllText("api.txt");

            var url = $"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{summonerName}?api_key={api}";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            var data = JObject.Parse(response.Content);

            var summoner = new Summoner();
            summoner.SummonerID = (string)data["id"];

            return summoner;
        }

        public static Summoner GetPlayerStats(this Summoner summoner)
        {
            var api = System.IO.File.ReadAllText("api2.txt");

            var url = $"https://na1.api.riotgames.com/lol/league/v4/entries/by-summoner/{summoner.SummonerID}?api_key={api}";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var data = JArray.Parse(response.Content);

            foreach (var obj in data)
            {
                if (obj["queueType"].ToString() == "RANKED_FLEX_SR")
                {
                    summoner.SummonerName = (string)obj["summonerName"];
                    summoner.FWins = (int)obj["wins"];
                    summoner.FLosses = (int)obj["losses"];
                    summoner.FTier = (string)obj["tier"];
                    summoner.FRank = (string)obj["rank"];
                    summoner.FLP = (int)obj["leaguePoints"];
                }

                if (obj["queueType"].ToString() == "RANKED_SOLO_5x5")
                {
                    summoner.SummonerName = (string)obj["summonerName"];
                    summoner.SDWins = (int)   obj["wins"];
                    summoner.SDLosses = (int) obj["losses"];
                    summoner.SDTier = (string)obj["tier"];
                    summoner.SDRank = (string)obj["rank"];
                    summoner.SDLP = (int)     obj["leaguePoints"];
                }
            }

            return summoner;
        }

        public static Summoner GetMostPlayed(this Summoner summoner)
        {
            var api = System.IO.File.ReadAllText("api2.txt");

            var url = $"https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{summoner.SummonerID}?api_key={api}";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var data = JArray.Parse(response.Content);

            summoner.MostPlayed = (int)data[0]["championId"];

            return summoner;
        }

        public static string GetChampionImage(int championId)
        {
            var url = $"http://ddragon.leagueoflegends.com/cdn/10.25.1/data/en_US/champion.json";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var data = JObject.Parse(response.Content).GetValue("data");

            var id = "";
            foreach(var obj in data)
            {
                foreach(var champion in obj)
                {
                    if ((int)champion["key"] == championId)
                    {
                        id = (string)champion["id"];
                    }
                }
                
            }

            return $"https://opgg-static.akamaized.net/images/lol/champion/{id}.png?image=c_scale,q_auto,w_140&v=1607480996";
        }
    }
}
