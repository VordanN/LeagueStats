using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
namespace LeageStats.Model.Match
{
    public class StatPerks
    {
        public StatPerks(
            int defense,
            int flex,
            int offense
        )
        {
            this.defense = defense;
            this.flex = flex;
            this.offense = offense;
        }

        public int defense { get; }
        public int flex { get; }
        public int offense { get; }
    }
}
