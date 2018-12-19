using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Scaffolding.Models
{
    public class ScaffoldingContext : DbContext
    {
        public ScaffoldingContext (DbContextOptions<ScaffoldingContext> options)
            : base(options)
        {
        }

        public DbSet<Scaffolding.Models.Movie> Movie { get; set; }
    }
}
