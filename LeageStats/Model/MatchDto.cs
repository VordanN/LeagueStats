using LeageStats.Model.Match;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeageStats.Model
{
    public class MatchDto
    {
        public MatchDto(
            Metadata metadata,
            Info info
        )
        {
            this.metadata = metadata;
            this.info = info;
        }

        public Metadata metadata { get; set; }

        public Info info { get; set; }
    }
}
