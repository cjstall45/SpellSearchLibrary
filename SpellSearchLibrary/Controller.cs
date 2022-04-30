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
                //parse spell name 
                var spell = new Spell();
                spell.name = spellData.GetProperty("name").GetString();

                //parse book spell is in
                SourceBook book;
                if (Enum.TryParse(spellData.GetProperty("source").GetString(),out book))
                {
                    spell.source = book;
                }

                //parse page spell is on
                spell.page = spellData.GetProperty("page").GetInt32();

                //parse spell level
                spell.level = spellData.GetProperty("level").GetInt32();

                //parse spell school
                spell.school = ConvetStringtoSpellSchool(spellData.GetProperty("school").GetString());

                //parse casting time
                var newTime = new CastingTime();
                newTime.number = spellData.GetProperty("time")[0].GetProperty("number").GetInt32();
                CastingUnit unit;
                if (Enum.TryParse(spellData.GetProperty("time")[0].GetProperty("unit").GetString(), out unit))
                {
                    newTime.unit = unit;
                }
                spell.time = newTime;

                //call parse spellRange
                spell.range = ParseSpellRange(spellData.GetProperty("range"));

                //parse all componets
                spell.components = ParseComponets(spellData.GetProperty("components"));
                
                //duration
                spell.duration = ParseSpellDuration(spellData.GetProperty("duration")[0]);

                //entries
                spell.entries = ParseEnteries(spellData);

                //classes
                spell.classes = ParseClasses(spellData.GetProperty("classes").GetProperty("fromClassList"));
                //add final spell to SpellList
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

        private SpellRange ParseSpellRange(JsonElement range)
        {
            var returnValue = new SpellRange();
            var distance = new Distance();

            SpellShape shape;
            if (Enum.TryParse(range.GetProperty("type").GetString(), out shape))
            {
                returnValue.type = shape;
            }
            if (returnValue.type != SpellShape.special)
            {
                DistanceUnits unit;
                if (Enum.TryParse(range.GetProperty("distance").GetProperty("type").GetString(), out unit))
                {
                    distance.type = unit;
                }

                JsonElement temp;
                if (range.GetProperty("distance").TryGetProperty("amount", out temp))
                {
                    distance.amount = temp.GetInt32();
                }
                returnValue.distance = distance;
            }
            else
            {
                returnValue.distance = null;
            }
            return returnValue;
        }

        private Components ParseComponets(JsonElement comps)
        {
            Components components = new Components();
            JsonElement compsStorage;
            //vocal
            if (comps.TryGetProperty("v", out compsStorage))
            {
                components.v = true;
            }
            else
            {
                components.v = false;
            }

            //semantic
            if (comps.TryGetProperty("s", out compsStorage))
            {
                components.s = true;
            }
            else
            {
                components.s = false;
            }

            //material
            if (comps.TryGetProperty("m", out compsStorage))
            {
                
                if (compsStorage.ValueKind == JsonValueKind.Object)
                {
                    components.m = compsStorage.GetProperty("text").GetString();
                }
                else
                {
                    components.m = compsStorage.GetString();
                }
            }
            else
            {
                components.m = null;
            }

            return components;
        }

        private SpellDuration ParseSpellDuration(JsonElement duration)
        {
            SpellDuration newDuration = new SpellDuration();
            DurationType type;
            if (Enum.TryParse(duration.GetProperty("type").GetString(), out type))
            {
                newDuration.type = type;
            }
            if(newDuration.type == DurationType.timed)
            {
                TimedDuration timed = new TimedDuration();
                TimeUnit unit;
                timed.amount = duration.GetProperty("duration").GetProperty("amount").GetInt32();
                if (Enum.TryParse(duration.GetProperty("duration").GetProperty("type").GetString(), out unit))
                {
                    timed.type = unit;
                }
                JsonElement temp;
                if(duration.TryGetProperty("concentration", out temp))
                {
                    timed.concentration = true;
                }
                else
                {
                    timed.concentration = false;
                }
                newDuration.time = timed;
            }
            else
            {
                newDuration.time = null;
            }
            return newDuration;
        }

        private List<string> ParseEnteries(JsonElement spell)
        {
            List<string> returnValue = new List<string>();
            JsonElement entries = spell.GetProperty("entries");
            foreach(JsonElement entry in entries.EnumerateArray())
            {
                if(entry.ValueKind == JsonValueKind.Object)
                {
                    switch (entry.GetProperty("type").GetString())
                    {
                        case "entries":
                            returnValue.Add(entry.GetProperty("name").GetString());
                            foreach(JsonElement entryString in entry.GetProperty("entries").EnumerateArray())
                            {
                                if(entryString.ValueKind != JsonValueKind.Object)
                                {
                                    returnValue.Add(entryString.GetString());
                                }
                                else
                                {
                                    foreach (JsonElement listEntry in entryString.GetProperty("items").EnumerateArray())
                                    {
                                        returnValue.Add(listEntry.GetString());
                                    }
                                }
                            }
                            break;
                        case "list":
                            foreach (JsonElement listEntry in entry.GetProperty("items").EnumerateArray())
                            {
                                returnValue.Add(listEntry.GetString());
                            }
                            break;
                        case "table":
                            returnValue.Add(" ***TABLES ARE NOT YET IMPLIMENTED*** ");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    returnValue.Add(entry.GetString());
                }
            }
            JsonElement higherLevels;
            if(spell.TryGetProperty("entriesHigherLevel", out higherLevels))
            {
                returnValue.Add("At Higher Levels, ");
                foreach(JsonElement element in higherLevels[0].GetProperty("entries").EnumerateArray())
                {
                    returnValue.Add(element.GetString());
                }
            }
            return returnValue;
        }

        private List<CharacterClass> ParseClasses(JsonElement classes)
        {
            List<CharacterClass> SpellClasses = new List<CharacterClass>();
            foreach(JsonElement newClass in classes.EnumerateArray())
            {
                CharacterClass character;
                if (Enum.TryParse(newClass.GetProperty("name").GetString(), out character))
                {
                    if(character != CharacterClass.Artificer)
                    {
                        SpellClasses.Add(character);
                    }
                    else if (!SpellClasses.Contains(CharacterClass.Artificer))
                    {
                        SpellClasses.Add(character);
                    }
                }
            }
            return SpellClasses;
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
