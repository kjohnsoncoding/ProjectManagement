using ProjectManagement.Data;
using ProjectManagement.Data.Entities;
using ProjectManagement.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Services
{
    public class CustomerService
    {
        private readonly Guid _userId;

        public CustomerService(Guid userId)
        {
            _userId = userId;
        }

        // Create Customer
        public bool CreateCustomer(CustomerCreate model)
        {
            var entity =
                new Customer()
                {
                    OwnerId = _userId,
                    Name = model.Name,
                    CustomerType = model.CustomerType,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    PhoneNumber = model.PhoneNumber,
                    EmailAddress = model.EmailAddress,
                    CustomerAdded = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Customers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get All Customers
        public IEnumerable<CustomerList> GetEmployees()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Customers
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                                e =>
                                    new CustomerList
                                    {
                                        CustomerId = e.CustomerId,
                                        CustomerName = e.Name,
                                        CustomerAdded = e.CustomerAdded
                                    }
                                );
                return query.ToArray();
            }
        }

        // Get Single Customer
        public CustomerDetail GetCustomerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == id && e.OwnerId == _userId);
                return
                    new CustomerDetail
                    {
                        CustomerId = entity.CustomerId,
                        Name = entity.Name,
                        CustomerType = entity.CustomerType,
                        Address = entity.Address,
                        City = entity.City,
                        State = entity.State,
                        PhoneNumber = entity.PhoneNumber,
                        EmailAddress = entity.EmailAddress,
                        CustomerAdded = entity.CustomerAdded,
                        LastUpdated = entity.LastUpdated
                    };
            }
        }

        // Update Customer
        public bool UpdateCustomer(CustomerUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == model.CustomerId && e.OwnerId == _userId);

                entity.Name = model.Name;
                entity.CustomerType = model.CustomerType;
                entity.Address = model.Address;
                entity.City = model.City;
                entity.State = model.State;
                entity.PhoneNumber = model.PhoneNumber;
                entity.EmailAddress = model.EmailAddress;
                entity.LastUpdated = DateTimeOffset.Now;

                return ctx.SaveChanges() == 1;
            }
        }

        // Delete Customer
        public bool DeleteCustomer(int customerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == customerId && e.OwnerId == _userId);

                ctx.Customers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
