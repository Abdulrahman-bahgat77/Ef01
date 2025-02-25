using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } //Pk [identity contain(1,1)]
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50,MinimumLength =10)] 
        public string?  EmpName { get; set; } //nullable<string> Allow null
                                              //nvarchar(max)
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; } //Decimal(18,12)
        [Range(20,60)]
        public int? Age { get; set; }  //Int
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public int Password { get; set; }

        [ForeignKey("Departments")]
        public int? DepartmentId { get; set; }

        [InverseProperty("Employees")]
        public virtual Department Departments { get; set; }
        //Nevagation Property=>One
    }
}
