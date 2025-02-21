using Ef01.Context;
using Ef01.Entities;
 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System.Security.Claims;
using System.Xml.Linq;

namespace Ef01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           EnterpriseDBContext dbContext=new EnterpriseDBContext();

            #region Session 1 
            //DbContext.Employees.Add();

            //Apply migrate
            //1-code
            // DbContext.Database.Migrate();

            //2-package manager console

            //try
            //{
            //    //Crud =>Query object Model
            //}
            //finally
            //{
            //    // Release || Free ||Deallocate ||Dispose ||Close
            //}
            // using EnterpriseDBContext dbContext = new EnterpriseDBContext()
            //{

            //};

            //using EnterpriseDBContext dbContext = new EnterpriseDBContext();
            #endregion

            #region Session2
            // Crud

            #region Crud operation

            //using EnterpriseDBContext dBContext = new EnterpriseDBContext();

            //Employee Emp1 = new Employee()
            //{

            //    EmpName = "Abdo",
            //    Age=22,
            //    Salary=20000,
            //    Email = "manomoo734@gmail.com",
            //    Password = 123456
            //};

            //Employee Emp2 = new Employee()
            //{

            //    EmpName = "omar",
            //    Age = 23,
            //    Salary = 30000,
            //    Email = "omar@gmail.com",
            //    Password = 123456789
            //};

            #region insert
            //Console.WriteLine(dbContext.Entry(Emp1).State);
            //Console.WriteLine(dbContext.Entry(Emp2).State);
            ////Save local
            //dbContext.Employees.Add(Emp1);
            //dbContext.Employees.Add(Emp2);
            //Console.WriteLine(dbContext.Entry(Emp1).State);
            //Console.WriteLine(dbContext.Entry(Emp2).State);
            ////Save to database
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Emp1).State);
            //Console.WriteLine(dbContext.Entry(Emp2).State);

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine($"Emp01={Emp1.Id}");
            //Console.WriteLine($"Emp02={Emp2.Id}");
            #endregion


            #region Read
            //var Employee = (from e in dbContext.Employees
            //                where e.Id == 1
            //                select e).FirstOrDefault();
            // Console.WriteLine(Employee?.EmpName ?? "Name");
            #endregion

            #region Update
            //var Employee = (from e in dBContext.Employees
            //                where e.Id == 2
            //                select e).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry(Employee).State);
            //Employee.Salary = 25000;
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion

            #region Delete
            //var Employee = (from e in dBContext.Employees
            //                where e.Id == 2
            //                select e).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            // dbContext.Employees.Remove(Employee);
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion
            #endregion

            //One to Many RealtionShip

            //Many To Many RealationShip

            // By:
                  //1.By Convention(Default Behavior)
                  //2.Data Annotation(Set Of Attributes Used For Data Validation)
                  //3.Fluent APIs(DbContext → Override OnModelCreating()) ==========>Used in make Composite PrimaryKey
                  //4.Configuration Class Per Entity(Organization To 3rd Way)

            #endregion



        }
    }
}
