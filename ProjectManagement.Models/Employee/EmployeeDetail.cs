using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Employee
{
    public class EmployeeDetail
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset EmployeeCreated { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }
}
