using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, Type type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public Type Type { get; private set; }
    }
}
