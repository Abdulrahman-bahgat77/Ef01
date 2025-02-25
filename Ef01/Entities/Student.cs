﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

        //public ICollection<Course> Courses { get; set; }
        public virtual ICollection<CourseStudent> CourseStudentes { get; set; }
    }
}
