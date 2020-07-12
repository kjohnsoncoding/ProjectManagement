using System;
using static ProjectManagement.Data.Entities.Customer;
using static ProjectManagement.Data.Entities.Employee;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using static ProjectManagement.Data.Entities.ProjectStatusEnum;

namespace ProjectManagement.Models.Project
{
    public class ProjectList
    {
        [Display(Name = "Job Number")]
        public int ProjectId { get; set; }
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name = "Start Date")]
        public DateTimeOffset ProjectStartDate { get; set; }
        [Display(Name = "Project Status")]
        public ProjectStatus ProjectStatus { get; set; }

        [Display(Name = "Employee")]
        public string EmployeeName { get; set; }
        public virtual Data.Entities.Employee Employee { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; }

        [Display(Name = "Customer")]
        public string CustomerName { get; set; }
        public virtual Data.Entities.Customer Customer { get; set; }
        public IEnumerable<SelectListItem> Customers { get; set; }
    }
}
