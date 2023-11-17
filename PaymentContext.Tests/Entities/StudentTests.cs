using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Email _email;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Student _student;

        public StudentTests()
        {
            _name = new Name("Bruce", "Wayne");
            _document = new Document("35111507795", EDocumentType.CPF);
            _email = new Email("batman@dc.com");
            _address = new Address("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "13400000");
            _student = new Student(_name, _document, _email,_address);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Fulano","Silva");
            var document = new Document("11111111111",EDocumentType.CPF);
            var email = new Email("email@email.com");
            var address = new Address("Rua Tal","23","Bairro","Cataguases","MG","BR","23233333");

            var subscription = new Subscription(DateTime.Now.AddDays(5));
            var payment = new PayPalPayment("2234", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Fulano", document, address, email);
            subscription.AddPayment(payment);
            var student = new Student(name, document, email, address);

            student.AddSubscription(subscription);
            student.AddSubscription(subscription);

            Assert.IsTrue(student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeveRetornarErroQuandoAssinaturaNaoTemPagamentos()
        {
            Assert.Fail();
        }
    }
}
