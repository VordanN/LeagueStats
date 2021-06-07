using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Runes
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Rune
    {
        public Rune()
        {
            icon = "";
        }

        public Rune(
            int id,
            string key,
            string icon,
            string name,
            string shortDesc,
            string longDesc
        )
        {
            this.id = id;
            this.key = key;
            this.icon = icon;
            this.name = name;
            this.shortDesc = shortDesc;
            this.longDesc = longDesc;
        }

        public int id { get; set; }
        public string key { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
    }

    public class Slot
    {
        public Slot(
            List<Rune> runes
        )
        {
            this.runes = runes;
        }

        public List<Rune> runes { get; }
    }

    public class Root
    {
        public Root()
        {
        }

        public Root(
            int id,
            string key,
            string icon,
            string name,
            List<Slot> slots
        )
        {
            this.id = id;
            this.key = key;
            this.icon = icon;
            this.name = name;
            this.slots = slots;
        }

        public int id { get; }
        public string key { get; }
        public string icon { get; }
        public string name { get; }
        public List<Slot> slots { get; }
    }
}
