using SpellSearchLibrary.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpellSearchLibrary.Model
{
    public class DisplaySpell
    {
        public string Name { get; set; }
        public SourceBook Source { get; set; }
        public int Page { get; set; }
        public int Level { get; set; }
        public SpellSchool School { get; set; }
        public string Time { get; set; }
        public SpellShape Shape { get; set; }
        public string Distance { get; set; }
        public bool Verbal { get; set; }
        public bool Somantic { get; set; }
        public string Material { get; set; }
        public string Duration { get; set; }
        public List<string> Entries { get; set; }
        public string Classes { get; set; }
    }
}
