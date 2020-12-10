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
            //request.AddHeader("x-rapidapi-key", "75659707a4mshbe175a73468d4e2p1b9494jsn356396c32494");
            //request.AddHeader("x-rapidapi-host", "amazon-product-reviews-keywords.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var data = JArray.Parse(response.Content);

            summoner.SummonerName = (string)data[0]["summonerName"];
            summoner.FWins = (int)data[0]["wins"];
            summoner.FLosses = (int)data[0]["losses"];
            summoner.FTier = (string)data[0]["tier"];
            summoner.FRank = (string)data[0]["rank"];
            summoner.FLP = (int)data[0]["leaguePoints"];

            summoner.SDWins = (int)data[1]["wins"];
            summoner.SDLosses = (int)data[1]["losses"];
            summoner.SDTier = (string)data[1]["tier"];
            summoner.SDRank = (string)data[1]["rank"];
            summoner.SDLP = (int)data[1]["leaguePoints"];

            return summoner;
        }
    }
}
