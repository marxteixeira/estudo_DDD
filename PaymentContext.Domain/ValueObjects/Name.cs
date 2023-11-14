using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;

            if (string.IsNullOrEmpty(name))
            {
                AddNotification("Student.Name", "Nome Inválido");
            }
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
