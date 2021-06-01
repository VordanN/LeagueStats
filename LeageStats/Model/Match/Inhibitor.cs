using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{

    public class Inhibitor
    {
        public Inhibitor(
            bool first,
            int kills
        )
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; }
        public int kills { get; }
    }
}
