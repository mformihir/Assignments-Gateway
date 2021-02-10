using CustomerEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Services
{
    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
             new Customer() { Id = 1, Address = "Test Address 1", Email = "test@test.com", MobileNumber = "1112221112"},
             new Customer() { Id = 2, Address = "Test Address 2", Email = "test@test.com", MobileNumber = "1112221112"},
            };

            return customers;
        }
    }
}
