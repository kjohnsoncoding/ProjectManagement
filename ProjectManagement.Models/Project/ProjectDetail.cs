using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Project
{
    public class ProjectDetail
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDetails { get; set; }
        public bool ProjectStatus { get; set; } = false;
        public DateTimeOffset ProjectStartDate { get; set; }
        public DateTimeOffset? ProjectUpdated { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
    }
}
