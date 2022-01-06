using System;

namespace Observer
{
    abstract class Observer
    {
        public abstract void getNotification(object Sender, string message, object data);
    }
}