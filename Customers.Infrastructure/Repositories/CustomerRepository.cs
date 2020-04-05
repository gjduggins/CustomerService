using System;
using System.Collections.Generic;
using System.Linq;
using Customers.Core.Entities;
using Customers.Core.Interfaces;

namespace Customers.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> _customers;
        public CustomerRepository()
        {
            _customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Surname = "Exotic",
                    Forename = "Joe"
                },
                new Customer
                {
                    Id = 2,
                    Surname = "Baskin",
                    Forename = "Carole"
                },
                new Customer
                {
                    Id = 3,
                    Surname = "Baskin",
                    Forename = "Howard"
                },
                new Customer
                {
                    Id = 4,
                    Surname = "Ansell",
                    Forename = "Doc"
                }
            };
        }

        public List<Customer> Get()
        {
            return _customers;
        }

        public Customer Get(int id)
        {
            return _customers.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
