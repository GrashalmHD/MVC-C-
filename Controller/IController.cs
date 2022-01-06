using System;
using ObserverPattern;

namespace Controller
{
    interface IController : Observer{
        public void start();
    }   
}