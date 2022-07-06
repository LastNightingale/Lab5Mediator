using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Sharp
{
    internal class Plane
    {
        public string Name { get; set; }
        public Terminal Terminal { set; get; }
        public LandingStrip Strip { set; get; }
        public Plane(string name)
        {
            Name = name;
        }
        public override string ToString()
        {        
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + "\n");
            if (Terminal != null) sb.Append(Terminal.ToString());
            if (Strip != null) sb.Append(Strip.ToString());
            return sb.ToString();
        }
    }
}
