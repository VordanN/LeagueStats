using LeageStats.API;
using LeageStats.Model;
using LeageStats.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Controller
{
    public class ControlerProfile
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var LeagueEntry = GetPosition(summoner);
            return new ModelProfile(summoner.Name,summoner.ProfileIconId,summoner.SummonerLevel,LeagueEntry.Tier,LeagueEntry.Rank,LeagueEntry.Wins,LeagueEntry.Losses);
        }

        private LeagueEntryDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Summoner.Region);

            var position = league.GetLeagueEntryDTOs(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new LeagueEntryDTO();

        }
    }
}
