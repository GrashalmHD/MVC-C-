using System;
using ObserverPattern;

namespace Model
{
    interface IModel{
        public void run();
        public void readFile();
        public void verifyAndConvertData();
        public void refresh();
        public void addObserver(Observer o);
    }   
}