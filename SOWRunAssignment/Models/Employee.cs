
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
 

namespace SOWRunAssignment.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee Number is required")]
        [StringLength(15,ErrorMessage = "Employee Number not more than 15 digit")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Employee Number must be numeric")]
        [DisplayName("Employee Number")]
        public string Empno { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [DisplayName("Employee Name")]
        public string  Ename { get; set; }
        [Required(ErrorMessage = "Employee Email Id is required")]
        [DisplayName("Employee Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
         
        public string EmailID { get; set; }
    }
}