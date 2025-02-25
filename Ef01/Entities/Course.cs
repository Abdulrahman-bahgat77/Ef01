using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Tittle { get; set; }

        //public ICollection<Student> Students { get; set; }

        public virtual ICollection<CourseStudent> CourseStudentes { get; set; }
    }
}
