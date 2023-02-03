using System;
namespace TaetrProjekt
{
	internal class Theatre
	{
		internal Hall[] halls = Array.Empty<Hall>();
		internal string Name { get; set; }
        public override string ToString()
        {
            return $"Name:{Name}";
        }
    }
}

