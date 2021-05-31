using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
namespace LeageStats.Model.Match
{
    public class Perks
    {
        public Perks(StatPerks statPerks, List<Style> styles)
        {
            this.statPerks = statPerks;
            this.styles = styles;
        }

        public StatPerks statPerks { get; }
        public List<Style> styles { get; }
    }

}
