using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Data.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CustomerAdded { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
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
