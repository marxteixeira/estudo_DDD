using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions= new List<Subscription>();

            AddNotifications(name, document, email, address);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); }}

        public void AddSubscription(Subscription subscription)
        {
            //regra 1...

            //regra 2...

            bool flag = false;

            foreach(var sub in Subscriptions)
            {
                if (sub.Active)
                {
                    flag= true;
                }
            }

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(flag, "Student.Subscriptions", "Existe uma assinatura ativa.")
                .AreEquals(0, subscription.Payments.Count,"Student.Subscription","Esta assinatura não possui pagamentos."));

          

            _subscriptions.Add(subscription);
        }
    }
}
