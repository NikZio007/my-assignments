using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApplication
{
    class Executor
    {
        public static void Main(string[] args)
        {
            bool check = true;
            NotificationApp myapp = new NotificationApp();
            while (check)
            {
                var result = myapp.PushNotification();
                if (result == false)
                {
                    check = false;
                }
            }
        }
    }
}
