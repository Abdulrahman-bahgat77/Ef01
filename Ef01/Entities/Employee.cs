using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    internal class Employee
    {
        public int Id { get; set; } //Pk [identity contain(1,1)]

        public string?  Name { get; set; } //nullable<string> Allow null
                                           //nvarchar(max)

        public decimal Salary { get; set; } //Decimal(18,12)

        public int? Age { get; set; }  //Int
    }
}
