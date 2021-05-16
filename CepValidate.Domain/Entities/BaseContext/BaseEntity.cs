using System;
using System.Collections.Generic;
using CepValidate.Domain.Notifications;
using System.Linq;

namespace CepValidate.Domain.Entities.BaseContext
{

    public class BaseEntity
    {
        List<Notification> _notifications;
        public BaseEntity()        
        {            
            Id = new Guid();
            _notifications = new List<Notification>();
        }
        public Guid Id {get;}
        public IReadOnlyList<Notification> Notifications => _notifications;

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);           
        }
    }
}