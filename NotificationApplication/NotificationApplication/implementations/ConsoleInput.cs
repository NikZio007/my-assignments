using NotificationApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApplication.implementations
{
    public class ConsoleInput
    {
        public static Notification GetNotificationObject()
        {
            Notification notification = new Notification();
            notification.Creator = "NikhilC";
            notification.CurrentTimeStamp = DateTime.Now;
            Console.WriteLine("\nEnter The Message");
            notification.Message = Console.ReadLine();
            return notification;
        }
    }
}
