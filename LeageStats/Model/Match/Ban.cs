
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// БАН
    /// </summary>
    public class Ban
    {
        public Ban(int championId, int pickTurn)
        {
            this.championId = championId;
            this.pickTurn = pickTurn;
        }

        public int championId { get; set; }
        public int pickTurn { get; set; }
    }
}
