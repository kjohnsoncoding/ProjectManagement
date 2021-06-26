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
            var employee =
                new Employee()
                {
                    OwnerId = _userId,
                    Name = model.Name,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    PhoneNumber = model.PhoneNumber,
                    EmailAddress = model.EmailAddress,
                    EmployeeCreated = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Employees.Add(employee);
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
                                        EmployeeId = e.EmployeeId,
                                        Name = e.Name,
                                        EmployeeCreated = e.EmployeeCreated
                                    }
                                );
                return query.ToArray();
            }
        }

        // Get Single Employees
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
                        Name = entity.Name,
                        Address = entity.Address,
                        City = entity.City,
                        State = entity.State,
                        PhoneNumber = entity.PhoneNumber,
                        EmailAddress = entity.EmailAddress,
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

                entity.Name = model.Name;
                entity.Address = model.Address;
                entity.City = model.City;
                entity.State = model.State;
                entity.PhoneNumber = model.PhoneNumber;
                entity.EmailAddress = model.EmailAddress;
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
