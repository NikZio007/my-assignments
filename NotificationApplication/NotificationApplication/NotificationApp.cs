using NotificationApplication.implementations;
using NotificationApplication.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApplication
{
    public class NotificationApp
    {
        public INotificationManager _manager { get; set; } 
        public NotificationApp()
        {
            _manager = new NotificationManager(new NotificationSender());
        }

        public bool PushNotification()
        {
            var notification = _manager.CreateNotification();
            var result = _manager.SendNotification(notification);
            return result ? true : false;
        }
        public void StopApplication()
        {
            Environment.Exit(1);
        } 
    }
}
