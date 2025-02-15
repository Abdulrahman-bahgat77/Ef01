using Ef01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Context
{
    internal class EnterpriseDBContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            optionsBuilder.UseSqlServer("Server= .; Database = Enterprise;Trusted_Connection = true");
        }
        public DbSet<Employee>  Employees{ get; set; }
        public DbSet<Departments> Departments { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<Projects> Projects { get; set; }
    }
}
