using System;
using View;
using Controller;
using ObserverPattern;

namespace Model
{
    class TestModel : Observable, IModel{
        
        public TestModel(){
            
        }
        public void run(){
            Console.WriteLine("Now running");
            refresh();
        }
        public void readFile(){
            Console.WriteLine("Reading file...");
        }
        public void verifyAndConvertData(){
            Console.WriteLine("Converting data...");
        }
        public void refresh(){
            Console.WriteLine("Refreshing View");
            notifyObservers(this,"Refresh View", "TestData");
        }
    }
}