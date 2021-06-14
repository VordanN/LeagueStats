using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// что-то связано с рунами
    /// </summary>
    public class Style
    {
        public Style(string description, List<Selection> selections, int style)
        {
            this.description = description;
            this.selections = selections;
            this.style = style;
        }

        public string description { get; set; }
        public List<Selection> selections { get; set; }
        public int style { get; set; }
    }
}
