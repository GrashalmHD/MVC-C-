using System;
using Controller;
using Model;

namespace View
{
    class TestView : IView
    {
        public void getNotification(object Sender, string message, object data){
            Console.WriteLine($"Message: {message} \n Sender: {(TestModel)Sender}\n Object: {data}");
        }
    }
}