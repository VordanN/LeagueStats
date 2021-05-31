using FileSystem;
using LeageStats.Model;
using LeageStats.Model.Match;
using LeageStats.Utilits;
using MessagePack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace LeageStats.API
{

    public class Match_V5 : API
    {
        public Match_V5(string region) : base(region)
        {
        }


        
        public MatchDto Read(string matchId)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(@"Matches\" + Constants.Summoner.Id + @"\" + matchId, FileMode.Open)))
            {
                byte[] bytes = reader.ReadBytes(int.Parse(reader.BaseStream.Length.ToString()));
                return Utf8Json.JsonSerializer.Deserialize<MatchDto>(bytes);
            }
            
        }

        public ModelStat GetModelSat(string matchId)
        {
            if (!Directory.Exists("Matches"))
                Directory.CreateDirectory("Matches");
            if (!Directory.Exists(@"Matches\" + Constants.Summoner.Id))
                Directory.CreateDirectory(@"Matches\" + Constants.Summoner.Id);

            string path = "match/v5/matches/" + matchId;

            Participant1 participants = new Participant1();
            if (File.Exists(@"Matches\"+Constants.Summoner.Id+@"\"+ matchId))
            {
                participants = ReadWrite.ReadJson<Root>(@"Matches\" + Constants.Summoner.Id + @"\" + matchId).info.participants.Where(p => p.puuid.Equals(Constants.Summoner.Puuid)).FirstOrDefault();
            }
            else
            {
                using (WebClient w = new WebClient())
                {
                    var json = w.DownloadString(GetURL(path,true));
                    Root d = JsonConvert.DeserializeObject<Root>(json);
                    foreach (Participant1 item in d.info.participants)
                    {
                        if (item.puuid == Constants.Summoner.Puuid)
                        {
                            participants = item;
                            break;
                        }
                    }
                    ReadWrite.WriteJson(d, @"Matches\" + Constants.Summoner.Id + @"\" + matchId);
                }
            }


            return new ModelStat()
            {
                assists = participants.assists,
                championName = participants.championName,
                champLevel = participants.champLevel,
                deaths = participants.deaths,
                goldEarned = participants.goldEarned,
                item0 = participants.item0,
                item1 = participants.item1,
                item2 = participants.item2,
                item3 = participants.item3,
                item4 = participants.item4,
                item5 = participants.item5,
                kills = participants.kills,
                neutralMinionsKilled = participants.neutralMinionsKilled,
                summoner1Id = participants.summoner1Id,
                summoner2Id = participants.summoner2Id,
                totalMinionsKilled = participants.totalMinionsKilled,
                win = participants.win
            };
        }

        public MatchDto GetMatchByMatchIDAsync(string matchId)
        {
            string path = "match/v5/matches/" + matchId;
            using (WebClient w = new WebClient())
            {
                var json = w.DownloadString(GetURL(path, true));
                return JsonConvert.DeserializeObject<MatchDto>(json);
            }
        }

        public List<MatchDto> GetMatchesByPuid(string puuid,int start = 0,int count = 20)
        {
            List<MatchDto> matchDtos = new List<MatchDto>();
            foreach (string match in GetMatchIDs(puuid,start,count))
            {
                matchDtos.Add(GetMatchByMatchIDAsync(match));
            }
            
            return matchDtos;
            
        }
        public List<string> GetMatchIDs(string puuid, int start = 0, int count = 20)
        {
            string path = "match/v5/matches/by-puuid/" + puuid + "/ids?start=" + start + "&count=" + count;

            var response = GET(GetURL(path, true, true));
            string context = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return  JsonConvert.DeserializeObject<List<string>>(context);
            }
            else { return null; }
        }
    }
}
