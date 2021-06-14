using FileSystem;
using LeageStats.Model;
using LeageStats.Utilits;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace LeageStats.API
{
    /// <summary>
    /// класс который позволяет получать матчи используя апи
    /// </summary>
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

        public MatchDto GetModelSat(string matchId)
        {
            string path = "match/v5/matches/" + matchId;
            _ = new MatchDto();
            MatchDto root;
            if (File.Exists(@"Matches\" + Constants.Summoner.Id + @"\" + matchId))
            {
                root = ReadWrite.ReadJson<MatchDto>(@"Matches\" + Constants.Summoner.Id + @"\" + matchId);
            }
            else
            {
                try
                {
                    string request;
                    using (WebClient client = new WebClient())
                    using (Stream stream = client.OpenRead(GetURL(path, true)))
                    using (StreamReader textReader = new StreamReader(stream, Encoding.UTF8, true))
                    {
                        request = textReader.ReadToEnd();
                    }
                    root = JsonConvert.DeserializeObject<MatchDto>(request);
                    ReadWrite.WriteJson(root, @"Matches\" + Constants.Summoner.Id + @"\" + matchId);
                }
                catch (System.Exception)
                {

                    return null;
                }
            }


            return root;
        }
        public int a()
        {
            _ = new int();
            _ = 5;


            return 5;
        }

        public MatchDto GetMatchByMatchID(string matchId)
        {
            string path = "match/v5/matches/" + matchId;
            using (WebClient w = new WebClient())
            {
                string json = w.DownloadString(GetURL(path, true));
                return JsonConvert.DeserializeObject<MatchDto>(json);
            }
        }

        public List<MatchDto> GetMatchesByPuid(string puuid, int start = 0, int count = 20)
        {
            List<MatchDto> matchDtos = new List<MatchDto>();
            foreach (string match in GetMatchIDs(puuid, start, count))
            {
                matchDtos.Add(GetMatchByMatchID(match));
            }

            return matchDtos;

        }
        public List<string> GetMatchIDs(string puuid, int start = 0, int count = 20)
        {
            string path = "match/v5/matches/by-puuid/" + puuid + "/ids?start=" + start + "&count=" + count;

            System.Net.Http.HttpResponseMessage response = GET(GetURL(path, true, true));
            string context = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<string>>(context);
            }
            else { return null; }
        }
    }
}
