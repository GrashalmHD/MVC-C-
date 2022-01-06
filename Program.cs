using System;
using Model;
using View;
using Controller;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            IView view = new TestView();
            IModel model = new TestModel();
            
            IController controller = new TestController(model,view);

            controller.start();

            Console.WriteLine("End of software");
            Console.ReadLine();
        }
    }
}
