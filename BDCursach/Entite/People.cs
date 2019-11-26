using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCursach.Entite
{
    class People
    {
        int IdPeople { get; set; }
        public string Nmae {get; set;}
        public string Soname {get; set;}
        public string Fname { get; set; }
        public string CallNumber { get; set; }
        public int IdRang { get; set; }
        public Rang Rang { get; set; }

    }
}
