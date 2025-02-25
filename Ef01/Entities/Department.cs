using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly DateOfCreation { get; set; }

        [InverseProperty("Departments")]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
