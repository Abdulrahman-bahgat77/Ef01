﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
