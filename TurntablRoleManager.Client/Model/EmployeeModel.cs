using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurntablRoleManager.Client.Model
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Please enter employee's first name")]
        [StringLength(50, ErrorMessage = "First Name can't be more than 50 characters.")]
        public string EmployeeFirstName { get; set; }

        [Required(ErrorMessage = "Please enter employee's last name")]
        [StringLength(50, ErrorMessage = "Last name can't be more than 50 characters.")]
        public string EmployeeLastName { get; set; }

        [Required(ErrorMessage = "Please enter employee's email")]
        [EmailAddress(ErrorMessage = "Please provide a valid e-mail address. eg. you@turntabl.io")]
        [StringLength(60, ErrorMessage = "Email can't be more than 60 characters.")]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Please enter employee's address")]
        [StringLength(255, ErrorMessage = "Address can't be more than 255 characters.")]
        public string EmployeeAddress { get; set; }

        [Required(ErrorMessage = "Please provide at least a role")]
        public List<string> RoleGuids { get; set; } = new List<string>();
    }
}
