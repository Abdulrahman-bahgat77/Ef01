using Microsoft.EntityFrameworkCore;
using Part_inheritance.context;
using Part_inheritance.Entities;

namespace Part_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Ali",
                Age = 22,
                Address = "Cairo",
                Salary = 5000,
                StartDate = DateTime.Now
            };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Ahmed",
                Age = 25,
                Address = "Giza",
                HourRate = 3,
                CountOfHours = 8
            };
            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //dbContext.PartTimeEmployees.Add(partTimeEmployee);
            //dbContext.SaveChanges();

            var Employee = (from ftb in dbContext.Employees
                            select ftb);



            foreach (var item in Employee.OfType<FullTimeEmployee>())
            {
                Console.WriteLine($"Name={item.Name}::Address={item.Address}");
            }
            Console.WriteLine("================");
            foreach (var item in Employee.OfType<PartTimeEmployee>())
            {
                Console.WriteLine($"Name:{item.Name}::Address:{item.Address}");
            }

        }
    }
}
