using NotificationSystemAPI.DataContract;
using NotificationSystemAPI.Service.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NotificationSystemAPI.Controllers
{
    [RoutePrefix("api/notification")]
    public class NotificationController : ApiController
    {
        public INotificationServiceManagement _service { set; get; }
        public NotificationController(INotificationServiceManagement service)
        {
            _service = service;
        }
        
        public NotificationController()
        {

        }

        [HttpPost]
        [Route("pushNotification")]
        public IHttpActionResult Post([FromBody]Notification notification)
        {
            Notification notify;
            try
            {
                notify = _service.InsertNotification(notification);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
            Ok(notify);
        }

    }
}
