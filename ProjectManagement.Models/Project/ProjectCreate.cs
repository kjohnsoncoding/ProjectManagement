using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using static ProjectManagement.Data.Entities.Enums;
using static ProjectManagement.Data.Entities.ProjectStatusEnum;

namespace ProjectManagement.Models.Project
{
    public class ProjectCreate
    {
        [Required]
        [Display(Name = "Project Name")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters in this field.")]
        [MaxLength(25, ErrorMessage = "There are too many characters in this field.")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Preferred Equipment")]
        public Equipment Equipment { get; set; }

        [Required]
        [Display(Name = "Vehicle")]
        public Vehicle Vehicle { get; set; }

        [Required]
        [Display(Name = "Project Information")]
        public string ProjectDetails { get; set; }

        [Required]
        [Display(Name = "Project Status")]
        public ProjectStatus ProjectStatus { get; set; }

        [Required]
        [Display(Name = "Employee")]
        public int? EmployeeId { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; }

        [Required]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public IEnumerable<SelectListItem> Customers { get; set; }
    }
}
