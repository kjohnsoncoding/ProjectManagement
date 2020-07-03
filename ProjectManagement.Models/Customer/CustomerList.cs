using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models.Customer
{
    public class CustomerList
    {
        [Display(Name = "ID")]
        public int CustomerId { get; set; }
        [Display(Name = "Customer")]
        public string CustomerName { get; set; }
        [Display(Name = "Added")]
        public DateTimeOffset CustomerAdded { get; set; }
    }
}
