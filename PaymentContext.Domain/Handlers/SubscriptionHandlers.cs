using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Command;
using PaymentContext.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandlers : Notifiable, IHandler<CreateBoletoSubscriptionCommand>
    {
        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            
        }
    }
}
