using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectManagement.Data.Entities.ProjectStatusEnum;

namespace ProjectManagement.Models.Project
{
    public class ProjectDetail
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDetails { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public DateTimeOffset ProjectStartDate { get; set; }
        public DateTimeOffset? ProjectUpdated { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
    }
}
