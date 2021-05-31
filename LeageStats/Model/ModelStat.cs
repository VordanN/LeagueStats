using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model
{
    public class ModelStat
    {
        public ModelStat()
        {
        }

        public ModelStat(string championName, int champLevel, int goldEarned, int neutralMinionsKilled, int totalMinionsKilled, int kills, int deaths, int assists, int summoner1Id, int summoner2Id, bool win, int item0, int item1, int item2, int item3, int item4, int item5)
        {
            this.championName = championName;
            this.champLevel = champLevel;
            this.goldEarned = goldEarned;
            this.neutralMinionsKilled = neutralMinionsKilled;
            this.totalMinionsKilled = totalMinionsKilled;
            this.kills = kills;
            this.deaths = deaths;
            this.assists = assists;
            this.summoner1Id = summoner1Id;
            this.summoner2Id = summoner2Id;
            this.win = win;
            this.item0 = item0;
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
        }

        public string championName { get; set; }
        public int champLevel { get; set; }
        public int goldEarned { get; set; }
        public int neutralMinionsKilled { get; set; }
        public int totalMinionsKilled { get; set; }

        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int summoner1Id { get; set; }
        public int summoner2Id { get; set; }
        public bool win { get; set; }

        public int item0 { get; set; }
        public int item1 { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }

    }
}
