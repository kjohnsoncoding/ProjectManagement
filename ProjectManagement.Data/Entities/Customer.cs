using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectManagement.Data.Entities.Enums;

namespace ProjectManagement.Data.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public CustomerType CustomerType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CustomerAdded { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }
}
