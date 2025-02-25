using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    public class CourseStudent
    {
        [ForeignKey("Student")]
        public int StudentsId { get; set; }
        [ForeignKey("Course")]
        public int CoursesId { get; set; }
        public int Grade { get; set; }
      public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
