using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Validation.Model
{
    public class CollegeContext: DbContext
    {

        public CollegeContext(DbContextOptions<CollegeContext>options)
            :base(options)
        { }
        public DbSet<Student>Students { get; set; }

    }
}
