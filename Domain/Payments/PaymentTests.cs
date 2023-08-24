using NUnit.Framework;

namespace TestShop.Domain.Payments
{
    [TestFixture]
    public class PaymentTests
    {
        private readonly Payment _payment;
        private const int Id = 1;
        private const string Name = "Cash";
        public PaymentTests()
        {
            _payment = new Payment();
        }
        [Test]
        public void TestSetAndGetId()
        {
            _payment.Id = Id;
            Assert.That(_payment.Id, Is.EqualTo(Id));
        }
        [Test]
        public void TestSetAndGetName()
        {
            _payment.Name = Name;
            Assert.That(_payment.Name, Is.EqualTo(Name));
        }
    }
}