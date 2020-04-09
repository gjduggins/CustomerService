using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Core.Entities;
using Customers.Core.Interfaces;
using Customers.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerRepository.Get();
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerRepository.Get(id);
        }
    }
}
