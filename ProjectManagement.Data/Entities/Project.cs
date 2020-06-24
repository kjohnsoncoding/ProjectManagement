﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Data.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer CustomerName { get; set; }

        [Required]
        public string ProjectDetails { get; set; }
        [Required]
        public bool ProjectStatus { get; set; }
        [Required]
        public DateTimeOffset ProjectStartDate { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee AssignedEmployee { get; set; }
    }
}
