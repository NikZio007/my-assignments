using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using NotificationApplication;
using NotificationApplication.interfaces;
using NotificationApplication.Model;
using NotificationApplication.implementations;

namespace NotificationApplication_Fixture
{
    public class Fixture
    {
        [Fact]
        void test_CreateNotification_for_returns_valid_object()
        {
            var manager = new Mock<INotificationManager>();
            manager.Setup(x => x.CreateNotification()).Returns(new Notification());
            Assert.NotNull(manager.Object.CreateNotification());
               
        }

        // [Fact]
        void test_CreateNotification_for_exception()
        {
            //var manager = new Mock<INotificationManager>();
            //manager.Setup(x => x.CreateNotification()).Throws(new Exception("Error!!"));
           
        }

        [Fact]
        void test_getNotificationMethod_for_object()
        {
            var result = ConsoleInput.GetNotificationObject();
            Assert.NotNull(result);
        }

        [Fact]
        void test_SendNotification_method_for_valid_Notification_Object()
        {
            Mock<INotifiactionSender> sender = new Mock<INotifiactionSender>();
            sender.Setup(x => x.Send(It.IsAny<Notification>())).Returns(true);
            NotificationManager manager = new NotificationManager(sender.Object);
            var result = manager.SendNotification(new Notification());
            Assert.True(result);
        }

        [Fact]
        void test_SendNotification_method_for_invalid_Notification_Object()
        {
            Mock<INotifiactionSender> sender = new Mock<INotifiactionSender>();
            sender.Setup(x => x.Send(It.IsAny<Notification>())).Returns(false);
            NotificationManager manager = new NotificationManager(sender.Object);
            var result = manager.SendNotification(new Notification());
            Assert.False(result);
        }

        [Fact]
        void test_Send_Method_for_sucess()
        {
            Notification notification= null;
            NotificationSender sender = new NotificationSender();
            Assert.Throws<Exception>(() => sender.Send(notification));
            
        }



    }
}
