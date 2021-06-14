using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// Класс в котором хранится классы с информацией которая происходила в игре/абьекти
    /// </summary>
    public class Objectives
    {
        public Objectives(Baron baron, Champion champion, Dragon dragon, Inhibitor inhibitor, RiftHerald riftHerald, Tower tower)
        {
            this.baron = baron;
            this.champion = champion;
            this.dragon = dragon;
            this.inhibitor = inhibitor;
            this.riftHerald = riftHerald;
            this.tower = tower;
        }

        public Baron baron { get; set; }
        public Champion champion { get; set; }
        public Dragon dragon { get; set; }
        public Inhibitor inhibitor { get; set; }
        public RiftHerald riftHerald { get; set; }
        public Tower tower { get; set; }
    }
}
