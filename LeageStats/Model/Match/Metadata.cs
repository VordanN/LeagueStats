

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// Класс мета информации
    /// </summary>
    public class Metadata
    {
        public Metadata(string dataVersion, string matchId, List<string> participants)
        {
            this.dataVersion = dataVersion;
            this.matchId = matchId;
            this.participants = participants;
        }

        public string dataVersion { get; set; }
        public string matchId { get; set; }
        public List<string> participants { get; set; }
    }



}
