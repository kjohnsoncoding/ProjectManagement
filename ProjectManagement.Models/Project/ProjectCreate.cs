using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectManagement.Data.Entities.ProjectStatusEnum;

namespace ProjectManagement.Models.Project
{
    public class ProjectCreate
    {
        public string ProjectName { get; set; }
        public string ProjectDetails { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }

    }
}
