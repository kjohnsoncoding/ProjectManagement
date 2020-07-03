using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Customer
{
    public class CustomerCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters in this field.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [MaxLength(2, ErrorMessage = "Please use State abbreviation (i.e. 'IN')")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [MinLength(12, ErrorMessage = "Please enter phone number in XXX-XXX-XXXX format")]
        [MaxLength(12, ErrorMessage = "Please enter phone number in XXX-XXX-XXXX format")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
