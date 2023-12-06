using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Info.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Info.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Specification> Specifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Specification>().HasData(
                new Specification
                {
                    Id = 1,
                    Name = "Ehsan",
                    Family = "Daneshvar",
                    Address = "-",
                    Birth = null
                }
            );
        }
    }
}
