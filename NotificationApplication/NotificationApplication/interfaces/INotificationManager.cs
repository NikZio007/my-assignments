using NotificationApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApplication.interfaces
{
    public interface INotificationManager
    {
        Notification CreateNotification();
        bool SendNotification(Notification notification);
    }
}
