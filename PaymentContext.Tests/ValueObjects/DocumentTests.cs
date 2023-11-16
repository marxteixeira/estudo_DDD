using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("10101010101")]
        [DataRow("10101010102")]
        [DataRow("10101010103")]
        public void DeveRetornarErroCPFInvalido(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);

            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoCPFValido()
        {
            var doc = new Document("00000000000", EDocumentType.CPF);

            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void DeveRetornarErroCNPJInvalido()
        {
            var doc = new Document("1111111111111", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoCNPJvalido()
        {
            var doc = new Document("11111111111111", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }
    }
}
