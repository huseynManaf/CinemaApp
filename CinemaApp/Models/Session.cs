using System;
namespace TaetrProjekt
{
	internal class Session:Entity
	{
		internal string Time { get; set; }
        internal string hall { get; set; }
        internal string film { get; set; }
        public override bool Equals(object? obj)
        {
            var session = obj as Session;
            return session.Id == Id;
        }
        public override string ToString()
            
        {
            return $"time:{Time}\n\nhall:{hall}";
        }
    }
}

