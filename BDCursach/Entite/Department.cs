using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCursach.Entite
{
    class Department
    {
        int IdDepartment { get; set; }
        IEnumerable<Staff> Staffs { get; set; }

    }
}
