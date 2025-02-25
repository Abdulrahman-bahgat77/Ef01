using Microsoft.EntityFrameworkCore;
using Part_inheritance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_inheritance.context
{
    class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;Integrated Security=True;");
        }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent Apis
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();

            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
