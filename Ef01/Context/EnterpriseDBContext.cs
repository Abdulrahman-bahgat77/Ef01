using Ef01.Configurations;
using Ef01.Entities;
using Ef01.Migrations;
using FluentApis;
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
        public DbSet<Products> Products { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Department> MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent Apis
            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.EmpName)
            //    .HasDefaultValue("Test");

            //modelBuilder.Entity<Department>(E =>
            //{

            //   E.HasKey(D => D.Id);

            //       E.Property(D => D.Id)
            //        .UseIdentityColumn(10, 10);


            //       E.Property(D => D.Name)
            //        .HasColumnName("DepartmentName")
            //        .HasMaxLength(50)
            //        .IsRequired(false);
            //    E.Property(D=>D.DateOfCreation)
            //    .hasDefaultValueSql("GETDATE()");

            //});
            #endregion

            modelBuilder.ApplyConfiguration(new DepartmentsConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
