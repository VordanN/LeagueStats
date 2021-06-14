using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeageStats.Model.Match
{
    /// <summary>
    /// класс рун
    /// </summary>
    public class Perks
    {
        public Perks(StatPerks statPerks, List<Style> styles)
        {
            this.statPerks = statPerks;
            this.styles = styles;
        }

        public StatPerks statPerks { get; set; }
        public List<Style> styles { get; set; }
    }

}
