using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestShop.Domain.Client
{
    [TestFixture]
    public class ClientTests
    {
        private readonly Client _client;
        private const int Id = 1;
        private const string Name = "Test";


        public ClientTests()
        {
            _client = new Client();
        }

        [Test]
        public void TestSetAndGetId()
        {
            _client.Id = Id;

            Assert.That(_client.Id, 
                Is.EqualTo(Id));
        }

        [Test]
        public void TestSetAndGetName()
        {
            _client.Name = Name;

            Assert.That(_client.Name, 
                Is.EqualTo(Name));
        }
    }
}
