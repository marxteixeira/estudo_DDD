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
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var name = new Name("Marx", "Teixeira");
            var document = new Document("12345678984",EDocumentType.CPF);
            var email = new Email("email@email.com");
            var address = new Address("","","","","","","");
            var student = new Student(name, document, email, address);

            foreach(var notif in student.Notifications)
            {
                notif.Message;
            }
        }
    }
}
