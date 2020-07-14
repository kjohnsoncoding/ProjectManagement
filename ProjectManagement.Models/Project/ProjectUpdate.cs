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
    public class ProjectUpdate
    {
        [Display(Name = "Project ID")]
        public int ProjectId { get; set; }
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name = "Preferred Equipment")]
        public Equipment Equipment { get; set; }
        [Display(Name = "Vehicle")]
        public Vehicle Vehicle { get; set; }
        [Display(Name = "Project Information")]
        public string ProjectDetails { get; set; }
        [Display(Name = "Project Status")]
        public ProjectStatus ProjectStatus { get; set; }

        //[Display(Name = "Employee")]
        //public string EmployeeName { get; set; }
        //public int? EmployeeId { get; set; }
        //public virtual Data.Entities.Employee Employee { get; set; }
        //public IEnumerable<SelectListItem> Employees { get; set; }

        //[Display(Name = "Customer")]
        //public string CustomerName { get; set; }
        //public int? CustomerId { get; set; }
        //public virtual Data.Entities.Customer Customer { get; set; }
        //public IEnumerable<SelectListItem> Customers { get; set; }
    }
}
