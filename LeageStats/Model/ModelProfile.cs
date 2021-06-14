using LeageStats.Utilits;
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
    /// <summary>
    /// Класс который принимает всю нужную информацию/дто
    /// </summary>
    public class ModelProfile
    {
        public ModelProfile(string summonerName, int icon, long level, string tier, string rank, int wins, int losses,int Lp)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon+".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            Emblem = "Resurses/Emblems/Season_2019_-_" + tier.ToUpper()[0]+tier.Substring(1) + "_"+Constants.convertRomanToInt(rank) +".png";
            Wins = wins;
            Losses = losses;
            LegaePoints = Lp;
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
