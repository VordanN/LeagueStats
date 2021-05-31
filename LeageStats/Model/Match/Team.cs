using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
namespace LeageStats.Model.Match
{
    public class Team
    {
        public Team(
            List<Ban> bans,
            Objectives objectives,
            int teamId,
            bool win
        )
        {
            this.bans = bans;
            this.objectives = objectives;
            this.teamId = teamId;
            this.win = win;
        }

        public List<Ban> bans { get; }
        public Objectives objectives { get; }
        public int teamId { get; }
        public bool win { get; }
    }

}
