using System;
using System.Collections.Generic;
using Customers.Core.Entities;

namespace Customers.Core.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer Get(int id);
    }
}
