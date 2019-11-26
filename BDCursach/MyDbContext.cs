using BDCursach.Entite;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCursach
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
           : base("DbConnection")
        { }

        public DbSet<People> Users { get; set; }
    }
}
