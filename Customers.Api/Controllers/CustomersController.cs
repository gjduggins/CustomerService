using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Core.Entities;
using Customers.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var repo = new CustomerRepository();
            return repo.Get();
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            var repo = new CustomerRepository();
            return repo.Get(id);
        }
    }
}
