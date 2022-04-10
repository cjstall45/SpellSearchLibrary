using SpellSearchLibrary.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpellSearchLibrary.Model
{
    public class Spell
    {
        public string name { get; set; }
        public SourceBook source { get; set; }
        public int page { get; set; }
        public bool srd { get; set; }
        public int level { get; set; }
        public SpellSchool school { get; set; }
        public CastingTime time { get; set; }
        public SpellRange range { get; set; }
        public Components components { get; set; }
        public SpellDuration duration { get; set; }
        //public entries
        //public scalingLevelDice
        //public damageInflict
        //public savingThrow
        //public PlayerClass classes[]

        public Dictionary<string, JsonElement> ExtensionData {get; set;}

    }
}
