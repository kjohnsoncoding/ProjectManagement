using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Employee
{
    public class EmployeeList
    {
        [Display(Name = "ID")]
        public int EmployeeId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Added")]
        public DateTimeOffset EmployeeCreated { get; set; }
    }
}
