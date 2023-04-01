using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLearnProject.Factory
{
    class MiddlewareOne : IMiddleware
    {
        public void DoPatching()
        {
            Console.WriteLine("Do patch number one");
        }
    }
}
