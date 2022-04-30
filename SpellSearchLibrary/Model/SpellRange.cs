using SpellSearchLibrary.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellSearchLibrary.Model
{
    public class SpellRange
    {
        public SpellShape type { get; set; }
        public Distance? distance { get; set; }
    }
}
