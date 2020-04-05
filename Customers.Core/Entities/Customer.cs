using System;
namespace Customers.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }

        public Customer()
        {
        }
    }
}
