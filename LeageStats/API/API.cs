using System.IO;
using System.Net.Http;

namespace LeageStats.API
{
    /// <summary>
    /// класс апи
    /// </summary>
    public class API
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public API(string region)
        {
            Region = region;
            //так как апи роботает 24 часа
            //всё плохзо
            //но если зайти на сайт https://developer.riotgames.com
            //войти в свой акк лиги
            //потом нажать на себя (в правом верхнем углу) 
            //после в DEVELOPMENT API KEY
            //будет ключ его вставить сюди
	    
            Key = <"ключ API">;
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

        protected string GetURL(string path, bool regionType = false, bool apitype = false)
        {
            if (regionType)
            {
                if (Region.Contains("NA") || Region.Contains("BR") || Region.Contains("LAN") || Region.Contains("LAS") || Region.Contains("OC"))
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
