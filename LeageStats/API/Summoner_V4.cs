using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.API
{
    /// <summary>
    /// Класс персонажа который роботает с апи
    /// </summary>
    public class Summoner_V4 : API
    {
        public Summoner_V4(string region) : base(region)
        {
        }
        
        public SummonerDTO GetSummonerByName(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/"+SummonerName;

            var response = GET(GetURL(path));
            string context = response.Content.ReadAsStringAsync().Result;

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(context);
            }
            return null;
        }

        
    }
}
