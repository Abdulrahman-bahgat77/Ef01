using Ef01.Configurations;
using Ef01.Entities;
using Ef01.Migrations;
 
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
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Projects> Projects { get; set; }
          public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluentApis
            #region FluentApis
            //modelBuilder.Entity<Employee>()
            //   .Property(E =>E.EmpName)
            //   .HasDefaultValue("Test")
            //   .IsRequired(false);

            // modelBuilder.Entity<Department>().ToTable("Departments");
            //modelBuilder.Entity<Department>()
            //      .HasKey(D=>D.Id);

            //  modelBuilder.Entity<Department>()
            //          .Property(D => D.Id)
            //          .UseIdentityColumn(10,10);
            //  modelBuilder.Entity<Department>()
            //   .Property(D => D.Name)
            //   .HasColumnName("Department Name")
            //   .HasColumnType("varchar")  
            //   .HasMaxLength(50)
            //   .HasDefaultValue("Test")
            //   .IsRequired(false);

            //  modelBuilder.Entity<Department>()
            //      .Property(D => D.DateOfCreation)
            //      .HasDefaultValueSql("GETDATE()");
            #endregion

            #region EF3.1 Feature
            //modelBuilder.Entity<Department>(E =>
            //{

            //      E.HasKey(D => D.Id);

            //      E.Property(D => D.Id)
            //    .UseIdentityColumn(10, 10);

            //     E.Property(D => D.Name)
            //     .HasColumnName("Department Name")
            //     .HasColumnType("varchar")
            //     .HasMaxLength(50)
            //     .HasDefaultValue("Test")
            //     .IsRequired(false);


            //        E.Property(D => D.DateOfCreation)
            //        .HasDefaultValueSql("GETDATE()");
            //});
            #endregion


          
           modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());

            modelBuilder.Entity<Department>()
              .HasMany(D => D.Employees)
              .WithOne(E => E.Departments)
              .HasForeignKey(E => E.DepartmentsId)
              .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Student>()
            //    .HasMany(S => S.Courses)
            //    .WithMany(C => C.Students);


        modelBuilder.Entity<CourseStudent>()
                .HasKey(CS => new { CS.CoursesId, CS.StudentsId });

         modelBuilder.Entity<Student>()
                 .HasMany(S=>S.CourseStudentes)
                 .WithOne(CS=>CS.Student)
                 .HasForeignKey(CS=>CS.StudentsId);

            modelBuilder.Entity<Course>()
                .HasMany(C => C.CourseStudentes)
                .WithOne(CS => CS.Course);

            base.OnModelCreating(modelBuilder);
        }
    }
}
