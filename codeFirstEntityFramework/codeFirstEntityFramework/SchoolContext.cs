using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace codeFirstEntityFramework
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
