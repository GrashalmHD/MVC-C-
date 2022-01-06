using System;

namespace ObserverPattern
{
    interface Observer
    {
        public void getNotification(object Sender, string message, object data);
    }
}