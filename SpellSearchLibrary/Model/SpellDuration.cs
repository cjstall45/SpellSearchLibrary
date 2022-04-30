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
        public DurationType type { get; set; }
        public TimedDuration? time { get; set; }
    }
}
