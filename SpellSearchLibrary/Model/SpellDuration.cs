using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpellSearchLibrary.Model.Enums;

namespace SpellSearchLibrary.Model
{
    public class SpellDuration
    {
        public string type { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement>? ExtensionData { get; set; }
    }
}
