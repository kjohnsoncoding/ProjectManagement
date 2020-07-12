using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectManagement.Data.Entities.Enums;
using static ProjectManagement.Data.Entities.ProjectStatusEnum;

namespace ProjectManagement.Data.Entities
{
    public class Project
    {
        [Required]
        public Guid OwnerId { get; set; }

        // Project Information
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public Equipment Equipment { get; set; }
        [Required]
        public Vehicle Vehicle { get; set; }
        [Required]
        public string ProjectDetails { get; set; }
        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        [Required]
        public DateTimeOffset ProjectStartDate { get; set; }
        public DateTimeOffset? ProjectUpdated { get; set; }

        // Customer Information 
        [Required, ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        // Employee Information
        [Required, ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
