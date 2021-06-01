using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{

    public class Objectives
    {
        public Objectives(
            Baron baron,
            Champion champion,
            Dragon dragon,
            Inhibitor inhibitor,
            RiftHerald riftHerald,
            Tower tower
        )
        {
            this.baron = baron;
            this.champion = champion;
            this.dragon = dragon;
            this.inhibitor = inhibitor;
            this.riftHerald = riftHerald;
            this.tower = tower;
        }

        public Baron baron { get; }
        public Champion champion { get; }
        public Dragon dragon { get; }
        public Inhibitor inhibitor { get; }
        public RiftHerald riftHerald { get; }
        public Tower tower { get; }
    }
}
