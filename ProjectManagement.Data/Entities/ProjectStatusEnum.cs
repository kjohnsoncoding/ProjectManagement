using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Data.Entities
{
    public class ProjectStatusEnum
    {
        public enum ProjectStatus
        {
            [Display(Name = "Planning")]
            PlanningStages = 1,
            [Display(Name = "In Progress")]
            InProgress,
            [Display(Name = "Project Completed")]
            ProjectCompleted
        }
    }
}
