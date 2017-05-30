using NotificationApplication.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationApplication.Model;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NotificationApplication.implementations
{
    public class NotificationSender : INotifiactionSender
    {
        private HttpClient client { set; get; }
        public NotificationSender()
        {
            client = new HttpClient();
        }
        
        public bool Send(Notification notification)
        {
            if (notification == null)
            {
                throw new Exception("Error");
            }

            client.BaseAddress = new Uri("http://localhost:60064/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.PostAsJsonAsync<Notification>("api/notification/pushNotification", notification).Result;
            return response.IsSuccessStatusCode  ? true : false;
        }
    }
}
