using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCursach.Entite
{
    class MedicineCard
    {
        int IdMedicineCard {get; set;}
        IEnumerable<Visit> HystoryVisits {get;set;}

    }
}
