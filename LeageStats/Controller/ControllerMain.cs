using LeageStats.API;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Controller
{
    public class ControllerMain
    {

        public bool GetSummener(string region,string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constants.Summoner = summoner;
            Constants.Region = region;
            return summoner != null;
        }
    }
}
