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
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public CustomerType CustomerType { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        public List<Customer> Customers { get; set; }
        [Required]
        public DateTimeOffset CustomerAdded { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }
}
