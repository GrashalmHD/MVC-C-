using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public delegate void observer(object Sender,string message, object data);

    abstract class Observable{
        List<Observer> observers = new List<Observer>();

        public void addObserver(Observer o){
            observers.Add(o);
        }
        public void removeObserver(Observer o){
            observers.Remove(o);
        }
        public void notifyObservers(object sender, string message, object data){
            foreach(Observer o in observers){
                o.getNotification(sender,message,data);
            }
        }
    }
}