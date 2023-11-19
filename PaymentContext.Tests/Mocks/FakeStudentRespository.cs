using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRespository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            throw new NotImplementedException();
        }

        public bool DocumentExists(string document)
        {
            if(document == "99999999999")
                return true;

            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "email@email.com")
                return true;

            return false;
        }
    }
}
