using System;
using Model;
using View;
using ObserverPattern;

namespace Controller
{
    class TestController : IController{

        IModel model;
        IView view;

        public TestController(IModel m, IView v){
            
            this.model = m;
            this.view = v;

            model.addObserver((Observer) v);
    
        }

        public void start(){

            model.readFile();

            model.verifyAndConvertData();

            model.run();
        }

        public void getNotification(object Sender, string message, object data){
            Console.WriteLine("Notify!");
        }
    }
}