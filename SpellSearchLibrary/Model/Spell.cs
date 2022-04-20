using SpellSearchLibrary.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SpellSearchLibrary.Model
{
    public class Spell
    {
        public string name { get; set; }
        public string source { get; set; }
        public int page { get; set; }
        public int level { get; set; }
        public string school { get; set; }
        public IEnumerable<CastingTime> time { get; set; }
        public SpellRange range { get; set; }
        public Components components { get; set; }
        public IEnumerable<SpellDuration> duration { get; set; }
        public List<string> entries { get; set; }
        public List<string> classes { get; set; }


        [JsonExtensionData]
        public Dictionary<string, JsonElement>? ExtensionData { get; set; }
    }
}
