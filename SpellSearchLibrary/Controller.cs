using System.Text.Json;
using SpellSearchLibrary.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SpellSearchLibrary.Model.Enums;

namespace SpellSearchLibrary
{
    public class Controller
    {
        private HttpClient client = new HttpClient();
        public List<Spell> Spells = new List<Spell>();

        public Controller()
        {
            var rawJson = GetSpells().Result;
             ParseSpells(JsonSerializer.Deserialize<JsonElement>(rawJson));
        }

        private async Task<string> GetSpells()
        {
             return await client.GetStringAsync("https://raw.githubusercontent.com/5etools-mirror-1/5etools-mirror-1.github.io/master/data/spells/spells-phb.json");
        }

        private void ParseSpells(JsonElement data)
        {
            JsonElement spellArray = data.GetProperty("spell");
            foreach(JsonElement spellData in spellArray.EnumerateArray())
            {
                var spell = new Spell();
                spell.name = spellData.GetProperty("name").ToString();
                SourceBook book;
                if (Enum.TryParse(spellData.GetProperty("source").ToString(),out book))
                {
                    spell.source = book;
                }
                spell.page = spellData.GetProperty("page").GetInt32();
                spell.level = spellData.GetProperty("level").GetInt32();
                var school = spellData.GetProperty("school").ToString();
                spell.school = ConvetStringtoSpellSchool(school);
                Spells.Add(spell);
            }
        }

       private SpellSchool ConvetStringtoSpellSchool(string school)
       {
            switch (school)
            {
                case "C":
                    return SpellSchool.Conjuration;
                case "A":
                    return SpellSchool.Abjuration;
                case "T":
                    return SpellSchool.Transmutation;
                case "E":
                    return SpellSchool.Enchantment;
                case "N":
                    return SpellSchool.Necromancy;
                case "D":
                    return SpellSchool.Divination;
                case "V":
                    return SpellSchool.Evocation;
                case "I":
                    return SpellSchool.Illusion;
                default:
                    return SpellSchool.Abjuration;
            }
       } 

       public IEnumerable<Spell> GetSpellsByLevel(int level)
        {
            return Spells;
            List<Spell> ReturnSpells = new List<Spell>();
            foreach(var spell in Spells)
            {
                if(spell.level == level)
                {
                    ReturnSpells.Add(spell);
                }
            }
            return ReturnSpells;
        }
    }
}
