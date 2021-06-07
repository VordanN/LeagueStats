using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model
{
    public class ModelProfile
    {
        public ModelProfile(string summonerName, int icon, long level, string tier, string rank, int wins, int losses,int Lp)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon+".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            Emblem = "emblems/Season_2019_-_" + tier.ToUpper()[0]+tier.Substring(1) + "_"+ convertRomanToInt(rank) +".png";
            Wins = wins;
            Losses = losses;
            LegaePoints = Lp;
        }
        
        private static int convertRomanToInt(String romanNumeral)
        {
            Dictionary<Char, Int32> romanMap = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            Int32 result = 0;
            for (Int32 index = romanNumeral.Length - 1, last = 0; index >= 0; index--)
            {
                Int32 current = romanMap[romanNumeral[index]];
                result += (current < last ? -current : current);
                last = current;
            }

            return result;
        }
        
        

        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int LegaePoints { get; private set; }

        
    }
}
