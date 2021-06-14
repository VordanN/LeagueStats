using LeageStats.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.API
{
    /// <summary>
    /// Класс который позволяет получать Входы в игру используя апи
    /// </summary>
    public class League_V4 : API
    {
        public League_V4(string region) : base(region)
        {
        }

        public List<LeagueEntryDTO> GetLeagueEntryDTOs(string encryptedSummonerId)
        {
            string path = "league/v4/entries/by-summoner/" + encryptedSummonerId;

            var response = GET(GetURL(path));
            string context = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(context);
            }
            return null;
        }
    }
}
