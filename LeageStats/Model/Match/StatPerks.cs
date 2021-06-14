using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// я заплуталяся но это связано с рунами хвыха
    /// </summary>
    public class StatPerks
    {
        public StatPerks(int defense, int flex, int offense)
        {
            this.defense = defense;
            this.flex = flex;
            this.offense = offense;
        }

        public int defense { get; set; }
        public int flex { get; set; }
        public int offense { get; set; }
    }
}
