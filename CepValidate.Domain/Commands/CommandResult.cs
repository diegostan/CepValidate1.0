using CepValidate.Domain.Commands.Interfaces;
using CepValidate.Domain.Notifications;
using System.Collections.Generic;

namespace CepValidate.Domain.Commands
{
    public class CommandResult:ICommandBase
    {        
        public CommandResult(bool ok, string propertyName, string message, IReadOnlyList<Notification> notifications)
        {
            
            Ok = ok;
            PropertyName = propertyName;
            Message = message;
            Notifications = notifications;
            
        }

        public bool Ok{get; private set;}
        public string PropertyName{get; private set;}
        public string Message{get; private set;}
        public IReadOnlyList<Notification> Notifications{get;}
        
    }
}