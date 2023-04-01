using System;
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

        }
    }
}
