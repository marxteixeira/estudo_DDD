using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Repository;
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
        private readonly IStudentRepository _studentRepository;

        public SubscriptionHandlers(IStudentRepository studentRepository)
        {
            _studentRepository= studentRepository;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            //validar o command para fail fast validation
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível realizar sua assinatura.");
            }

            //verificar se o documento já existe

        }
    }
}
