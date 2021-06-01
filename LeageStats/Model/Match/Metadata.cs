

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{

    public class Metadata
    {
        public Metadata(
            string dataVersion,
            string matchId,
            List<string> participants
        )
        {
            this.dataVersion = dataVersion;
            this.matchId = matchId;
            this.participants = participants;
        }

        public string dataVersion { get; }
        public string matchId { get; }
        public List<string> participants { get; }
    }

}
