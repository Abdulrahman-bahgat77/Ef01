using Ef01.Context;
using Microsoft.EntityFrameworkCore;

namespace Ef01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseDBContext DbContext=new EnterpriseDBContext();

            //DbContext.Employees.Add();

            //Apply migrate
            //1-code
            DbContext.Database.Migrate();

            //2-package manager console

        }
    }
}
