using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjectManagement.Data.Entities
{
    public class Repositories
    {
        public class CustomerRepo
        {
            public IEnumerable<SelectListItem> GetCustomers()
            {
                using (var ctx = new ApplicationDbContext())
                {
                    List<SelectListItem> customers =
                        ctx.Customers.AsNoTracking()
                            .OrderBy(n => n.Name)
                            .Select(n =>
                                new SelectListItem
                                {
                                    Value = n.CustomerId.ToString(),
                                    Text = n.Name
                                }).ToList();
                    var customerTip = new SelectListItem()
                    {
                        Value = null,
                        Text = "Select Customer"
                    };
                    customers.Insert(0, customerTip);
                    return new SelectList(customers, "Value", "Text");
                }
            }
        }

        public class EmployeeRepo
        {
            public IEnumerable<SelectListItem> GetEmployees()
            {
                using (var ctx = new ApplicationDbContext())
                {
                    List<SelectListItem> employees =
                        ctx.Employees.AsNoTracking()
                            .OrderBy(n => n.Name)
                            .Select(n =>
                                new SelectListItem
                                {
                                    Value = n.EmployeeId.ToString(),
                                    Text = n.Name
                                }).ToList();
                    var employeeTip = new SelectListItem()
                    {
                        Value = null,
                        Text = "Select Employee"
                    };
                    employees.Insert(0, employeeTip);
                    return new SelectList(employees, "Value", "Text");
                }
            }
        }
    }
}
