using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
namespace LeageStats.Model.Match
{
    public class Style
    {
        public Style(
            string description,
            List<Selection> selections,
            int style
        )
        {
            this.description = description;
            this.selections = selections;
            this.style = style;
        }

        public string description { get; }
        public List<Selection> selections { get; }
        public int style { get; }
    }
}
