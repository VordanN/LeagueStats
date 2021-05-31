using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace LeageStats.API
{
    public class API
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public API(string region)
        {
            Region = region;
            Key = "RGAPI-c0edee35-22a5-4eff-84d0-c07a386071a6";
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();
                return result.Result;
            }
        }

        protected string GetURL(string path,bool regionType = false,bool apitype = false)
        {
            if (regionType)
            {
                if (Region.Contains("NA")|| Region.Contains("BR") || Region.Contains("LAN") || Region.Contains("LAS") || Region.Contains("OC"))
                {
                    Region = "AMERICAS".ToLower();
                }
                if (Region.Contains("KR") || Region.Contains("JP"))
                {
                    Region = "ASIA".ToLower();
                }
                if (Region.Contains("EUN") || Region.Contains("EUW") || Region.Contains("TR") || Region.Contains("RU"))
                {
                    Region = "EUROPE".ToLower();
                }
            }
            if (apitype)
            {
                return "https://" + Region + ".api.riotgames.com/lol/" + path + "&api_key=" + Key;
            }
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
