using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_StudentDatabase
{

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}
