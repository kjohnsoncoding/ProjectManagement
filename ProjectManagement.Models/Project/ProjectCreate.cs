using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectManagement.Data.Entities.Enums;
using static ProjectManagement.Data.Entities.ProjectStatusEnum;

namespace ProjectManagement.Models.Project
{
    public class ProjectCreate
    {
        [Display(Name = "Project Name")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters in this field.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string ProjectName { get; set; }
        [Display(Name = "Preferred Equipment")]
        public Equipment Equipment { get; set; }
        [Display(Name = "Vehicle")]
        public Vehicle Vehicle { get; set; }
        [Display(Name = "Project Information")]
        public string ProjectDetails { get; set; }
        [Display(Name = "Project Status")]
        public ProjectStatus ProjectStatus { get; set; }
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

    }
}
