using System;
using DesignPatternsLearnProject.Bridge1;
using DesignPatternsLearnProject.Factory;

namespace DesignPatternsLearnProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var factory = new MiddlewareFactory();
            IMiddleware software = factory.GetMiddleware(1);
            software.DoPatching();
            /*-------Bridge testing functionality----*/
            Abstraction abstraction = new DerivedAbstraction();
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.DoOperation();
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.DoOperation();

        }
    }
}
