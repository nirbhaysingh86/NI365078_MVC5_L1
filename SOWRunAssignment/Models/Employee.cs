
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
 

namespace SOWRunAssignment.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee Number is required")]
        [StringLength(15,ErrorMessage = "Employee Number not more than 15 digit")]
        [DisplayName("Employee Number")]
        public string Empno { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [DisplayName("Employee Name")]
        public string  Ename { get; set; }
        [Required(ErrorMessage = "Employee Email Id is required")]
        [DisplayName("Employee Email Address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailID { get; set; }
    }
}