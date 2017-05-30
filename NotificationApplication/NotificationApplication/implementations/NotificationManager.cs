using NotificationApplication.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationApplication.Model;

namespace NotificationApplication.implementations
{
    public class NotificationManager : INotificationManager
    {
        public INotifiactionSender _sender { set; get; }
        public NotificationManager(INotifiactionSender sender)
        {
            _sender = sender;
        }
        public Notification CreateNotification()
        {
            var notification =ConsoleInput.GetNotificationObject();
            if(notification == null)
            {
                throw new Exception("Failed To Create Notification");
            }
            return notification;
        }

        public bool SendNotification(Notification notification)
        {
           return  _sender.Send(notification);
        }
    }
}
