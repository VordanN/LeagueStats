using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeageStats.Model.Match
{
    /// <summary>
    /// иноформация о команде
    /// </summary>
    public class Team
    {
        public Team(List<Ban> bans, Objectives objectives, int teamId, bool win)
        {
            this.bans = bans;
            this.objectives = objectives;
            this.teamId = teamId;
            this.win = win;
        }

        public List<Ban> bans { get; set; }
        public Objectives objectives { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
    }
}
