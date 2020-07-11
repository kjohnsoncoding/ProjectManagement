using ProjectManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectManagement.Data.Entities.Enums;

namespace ProjectManagement.Models.Customer
{
    public class CustomerCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters in this field.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }
        [Display(Name = "Customer Type")]
        public CustomerType CustomerType { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public Data.Entities.State State { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [MinLength(12, ErrorMessage = "Please enter phone number in XXX-XXX-XXXX format")]
        [MaxLength(12, ErrorMessage = "Please enter phone number in XXX-XXX-XXXX format")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }

    //public enum State
    //{
    //    Alabama,
    //    Alaska,
    //    Arizona,
    //    Arkansas,
    //    California,
    //    Colorado,
    //    Connecticut,
    //    Delaware,
    //    Florida,
    //    Georgia,
    //    Hawaii,
    //    Idaho,
    //    Illinois,
    //    Indiana,
    //    Iowa,
    //    Kansas,
    //    Kentucky,
    //    Louisiana,
    //    Maine,
    //    Maryland,
    //    Massachusetts,
    //    Michigan,
    //    Minnesota,
    //    Mississippi,
    //    Missouri,
    //    Montana,
    //    Nebraska,
    //    Nevada,
    //    New_Hampshire,
    //    New_Jersey,
    //    New_Mexico,
    //    New_York,
    //    North_Carolina,
    //    North_Dakota,
    //    Ohio,
    //    Oklahoma,
    //    Oregon,
    //    Pennsylvania,
    //    Rhode_Island,
    //    South_Carolina,
    //    South_Dakota,
    //    Tennessee,
    //    Texas,
    //    Utah,
    //    Vermont,
    //    Virginia,
    //    Washington,
    //    West_Virginia,
    //    Wisconsin,
    //    Wyoming
    //}
}
