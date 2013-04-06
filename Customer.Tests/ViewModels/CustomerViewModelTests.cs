using Customers.ViewModels;
using NUnit.Framework;

namespace Customer.Tests.ViewModels
{
    [TestFixture]
    public class CustomerViewModelTests
    {
        // Should return display rate as Gold if rating service is One
        // Should return display rate as Ordinary if rating service is Zero

        [Test]
        public void ShouldReturnDisplayRateAsGoldIfRatingIsOne()
        {
            var sut = new CustomerViewModel(1);
            sut.Name = "Puff Daddy in the House";
            var result = sut.DisplayRate;
            Assert.That(result, Is.EqualTo("Gold"));
        }

        [Test]
        public void ShouldReturnRateAsOrdinaryIfRatingIsZero()
        {
            var sut = new CustomerViewModel(1);
            sut.Name = "Bob";
            var result = sut.DisplayRate;
            Assert.That(result, Is.EqualTo("Ordinary"));
        }
         
    }
}