using Customers.DTO;
using Customers.Services;
using NUnit.Framework;

namespace Customers.Tests.Services
{
    [TestFixture]
    public class RatingServiceTests
    {
        //Should Rate Person with name that does not contain Puff Daddy as Zero
        //Should Rate Person with name that does contain Puff Daddy as One        

        [Test]
        public void ShouldRatePersonWithNameThatDoesNotContainPuffDaddyAsZero()
        {
            // Arrange
            const int expectedRate = 0;
            var sut = new RatingService();
            var customer = new Customer { Name = "DoesNotContainName", Id = 1 };

            // Act
            var result = sut.Rate(customer);

            // Assert
            Assert.AreEqual(result, expectedRate);
        }

        [Test]
        public void ShouldRatePersonWithNameThatContainsPuffDaddyAsOne()
        {
            // Arrange
            const int expectedRate = 1;
            var sut = new RatingService();
            var customer = new Customer { Name = "Contains Puff Daddy", Id = 1 };

            // Act
            var result = sut.Rate(customer);

            // Assert
            Assert.AreEqual(result, expectedRate);
        }
    }
}