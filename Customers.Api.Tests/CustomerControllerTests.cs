using Customers.Core.Entities;
using Customers.Core.Interfaces;
using Customers.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Customers.Api.Tests
{
    [TestClass]
    public class CustomersControllerTests
    {
        [TestMethod]
        public void GetCustomerByIdReturnsCustomer()
        {
            // Arrange
            var cust = new Customer
            {
                Id = 1,
                Surname = "Exotic",
                Forename = "Joe"
            };

            var repo = new Mock<ICustomerRepository>();
            repo.Setup(x => x.Get(1)).Returns(cust);

            var controller = new CustomersController(repo.Object);

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.AreEqual(1, result.Id);
        }
    }
}
