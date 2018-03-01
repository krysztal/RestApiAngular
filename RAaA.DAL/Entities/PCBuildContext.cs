using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RAaA.DAL.Entities
{
    public class PCBuildContext : DbContext
    {
        public DbSet<PCBuild> PCBuilds { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<RAM> RAMs { get; set; }

        public PCBuildContext(DbContextOptions<PCBuildContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
