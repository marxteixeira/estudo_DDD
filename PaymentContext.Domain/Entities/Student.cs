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
        private IList<Subscription> _subscriptions;

        public Student(string name, string lastName, string document, string email, string address)
        {
            Name = name;
            LastName = lastName;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions= new List<Subscription>();
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); }}

        public void AddSubscription(Subscription subscription)
        {
            //regra 1...

            //regra 2...

            foreach(var sub in Subscriptions)
            {
                sub.Active = false;
            }

            _subscriptions.Add(subscription);
        }
    }
}
