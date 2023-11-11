using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public string Name { get;  set; }
        public string LastName { get; set; }
        public string Document { get;  set; }
        public string Email { get; set; }
        public string Address { get;  set; }
    }
}
