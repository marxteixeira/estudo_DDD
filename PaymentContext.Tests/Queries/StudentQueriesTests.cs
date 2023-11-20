using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueriesTests
    {
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            _students = new List<Student>();
            for (var i = 0; i <= 10; i++)
            {
                _students.Add(new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("1111111111" + i.ToString(), EDocumentType.CPF),
                    new Email(i.ToString() + "@marx.io"),
                    new Address("", "", "", "", "", "", "")
                )) ;
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNoExists()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }

    }
}
