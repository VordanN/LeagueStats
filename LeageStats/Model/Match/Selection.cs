using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// ПОд руны
    /// </summary>
    public class Selection
    {
        public Selection(int perk, int var1, int var2, int var3)
        {
            this.perk = perk;
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }

        public int perk { get; set; }
        public int var1 { get; set; }
        public int var2 { get; set; }
        public int var3 { get; set; }
    }
}
