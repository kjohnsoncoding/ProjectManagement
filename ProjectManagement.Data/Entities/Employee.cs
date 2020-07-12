using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using static ProjectManagement.Data.Entities.Enums;

namespace ProjectManagement.Data.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        public List<Employee> Employees { get; set; }
        [Required]
        public DateTimeOffset EmployeeCreated { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }
}
