using ProjectManagement.Data;
using ProjectManagement.Data.Entities;
using ProjectManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Services
{
    public class EmployeeService
    {
        private readonly Guid _userId;

        public EmployeeService(Guid userId)
        {
            _userId = userId;
        }

        // Create Employee
        public bool CreateEmployee(EmployeeCreate model)
        {
            var entity =
                new Employee()
                {
                    OwnerId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmployeeCreated = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Employees.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get All Employees
        public IEnumerable<EmployeeList> GetEmployees()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Employees
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                                e =>
                                    new EmployeeList
                                    {
                                        FirstName = e.FirstName,
                                        LastName = e.LastName,
                                        EmployeeCreated = e.EmployeeCreated
                                    }
                                );
                return query.ToArray();
            }
        }

        // Get Single Employee
        public EmployeeDetail GetEmployeeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == id && e.OwnerId == _userId);
                return
                    new EmployeeDetail
                    {
                        EmployeeId = entity.EmployeeId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        EmployeeCreated = entity.EmployeeCreated,
                        LastUpdated = entity.LastUpdated
                    };
            }
        }

        // Update Employee
        public bool UpdateEmployee(EmployeeUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == model.EmployeeId && e.OwnerId == _userId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.LastUpdated = DateTimeOffset.Now;

                return ctx.SaveChanges() == 1;
            }
        }

        // Delete Employee
        public bool DeleteEmployee(int employeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == employeeId && e.OwnerId == _userId);

                ctx.Employees.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
