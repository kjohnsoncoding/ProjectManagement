using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Project
{
    public class ProjectList
    {
        [Display(Name = "ID")]
        public int ProjectId { get; set; }
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name = "Start Date")]
        public DateTimeOffset ProjectStartDate { get; set; }
    }
}
