using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Customer
{
    public class CustomerDetail
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTimeOffset CustomerAdded { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }
}
