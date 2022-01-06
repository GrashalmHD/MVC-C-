using System;
using System.Collections.Generic;

namespace Observer
{
    public delegate void observer(object Sender,string message, object data);

    abstract class Observable{
        observer observers;

        public void subscribe(observer o){
            observers += o;
        }
        public void unsubscribe(observer o){
            observers -= o;
        }
        public void notifyObservers(object Sender, string message, object data){
            observers(Sender,message,data);
        }
    }
}