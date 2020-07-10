using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjectManagement.Data.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset EmployeeCreated { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }

    public enum State
    {
        [Display(Name = "Alabama")]
        Alabama = 1,
        [Display(Name = "Alaska")]
        Alaska,
        [Display(Name = "Arizona")]
        Arizona,
        [Display(Name = "Arkansas")]
        Arkansas,
        [Display(Name = "California")]
        California,
        [Display(Name = "Colorado")]
        Colorado,
        [Display(Name = "Connecticut")]
        Connecticut,
        [Display(Name = "Delaware")]
        Delaware,
        [Display(Name = "Florida")]
        Florida,
        [Display(Name = "Georgia")]
        Georgia,
        [Display(Name = "Hawaii")]
        Hawaii,
        [Display(Name = "Idaho")]
        Idaho,
        [Display(Name = "Illinois")]
        Illinois,
        [Display(Name = "Indiana")]
        Indiana,
        [Display(Name = "Iowa")]
        Iowa,
        [Display(Name = "Kansas")]
        Kansas,
        [Display(Name = "Kentucky")]
        Kentucky,
        [Display(Name = "Louisiana")]
        Louisiana,
        [Display(Name = "Maine")]
        Maine,
        [Display(Name = "Maryland")]
        Maryland,
        [Display(Name = "Massachusetts")]
        Massachusetts,
        [Display(Name = "Michigan")]
        Michigan,
        [Display(Name = "Minnesota")]
        Minnesota,
        [Display(Name = "Mississippi")]
        Mississippi,
        [Display(Name = "Missouri")]
        Missouri,
        [Display(Name = "Montana")]
        Montana,
        [Display(Name = "Nebraska")]
        Nebraska,
        [Display(Name = "Nevada")]
        Nevada,
        [Display(Name = "New Hampshire")]
        NewHampshire,
        [Display(Name = "New Jersey")]
        NewJersey,
        [Display(Name = "New Mexico")]
        NewMexico,
        [Display(Name = "New York")]
        NewYork,
        [Display(Name = "North Carolina")]
        NorthCarolina,
        [Display(Name = "North Dakoa")]
        NorthDakota,
        [Display(Name = "Ohio")]
        Ohio,
        [Display(Name = "Oklahoma")]
        Oklahoma,
        [Display(Name = "Oregon")]
        Oregon,
        [Display(Name = "Pennsylvania")]
        Pennsylvania,
        [Display(Name = "Rhode Island")]
        RhodeIsland,
        [Display(Name = "South Carolina")]
        SouthCarolina,
        [Display(Name = "South Dakota")]
        SouthDakota,
        [Display(Name = "Tennessee")]
        Tennessee,
        [Display(Name = "Texas")]
        Texas,
        [Display(Name = "Utah")]
        Utah,
        [Display(Name = "Vermont")]
        Vermont,
        [Display(Name = "Virginia")]
        Virginia,
        [Display(Name = "Washington")]
        Washington,
        [Display(Name = "West Virginia")]
        WestVirginia,
        [Display(Name = "Wisconsin")]
        Wisconsin,
        [Display(Name = "Wyoming")]
        Wyoming
    }
}
