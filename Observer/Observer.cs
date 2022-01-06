using System;

namespace ObserverPattern
{
    abstract class Observer
    {
        public abstract void getNotification(object Sender, string message, object data);
    }
}