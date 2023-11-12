using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
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
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, string lastName, string document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions= new List<Subscription>();
        }

        public Name Name { get; private set; }
        public string Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); }}

        public void AddSubscription(Subscription subscription)
        {
            //regra 1...

            //regra 2...

            foreach(var sub in Subscriptions)
            {
                sub.Inactivate ();
            }

            _subscriptions.Add(subscription);
        }
    }
}
