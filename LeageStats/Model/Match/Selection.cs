using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
namespace LeageStats.Model.Match
{
    public class Selection
    {
        public Selection(
            int perk,
            int var1,
            int var2,
            int var3
        )
        {
            this.perk = perk;
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }

        public int perk { get; }
        public int var1 { get; }
        public int var2 { get; }
        public int var3 { get; }
    }
}
