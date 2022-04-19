using System.Text.Json;
using SpellSearchLibrary.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                var spell = new Spell() { name = spellData.GetProperty("name").ToString() };
                Spells.Add(spell);
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
