using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCursach.Entite
{
    class Visit
    {
        int IdVisit { get; set; }
        public int IdPeople { get; set; }
        public People People { get; set; }
        public DateTime DateVisit { get; set; }
        public DateTime DateLastVisit { get; set; }
        public string TreatmentHistory { get; set; }

    }
}
