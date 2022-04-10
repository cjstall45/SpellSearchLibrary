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
        public SpellList Spells;

        public Controller()
        {
            var rawJson = GetSpells().Result;
            Spells = JsonSerializer.Deserialize<SpellList>(rawJson);
        }

        private async Task<string> GetSpells()
        {
             return await client.GetStringAsync("https://raw.githubusercontent.com/5etools-mirror-1/5etools-mirror-1.github.io/master/data/spells/spells-phb.json");
        }

        public IEnumerable<Spell> GetSpellsByLevel(int level)
        {
            List<Spell> ReturnSpells = new List<Spell>();
            foreach(var spell in Spells.spell)
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
