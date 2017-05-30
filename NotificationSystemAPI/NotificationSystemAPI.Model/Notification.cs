using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemAPI.Model
{
    public class Notification
    {
        public string NotificationId { set; get; }
        public string Message { set; get; }
        public DateTime CurrentTimeStamp { get; set; }
        public string Creator { set; get; }
    }
}
