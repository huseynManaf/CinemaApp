using System;
using System.Data.Common;
using System.Xml.Linq;

namespace TaetrProjekt
{
    public class Hall : Entity
    {
        internal string Name { get; set; }
        internal int Raw { get; set; }
        internal int Column { get; set; }
        public override string ToString()
        {
            return $"name:{Name}\nraw:{Raw}\ncolumn:{Column}";
        }
    }
}
        



