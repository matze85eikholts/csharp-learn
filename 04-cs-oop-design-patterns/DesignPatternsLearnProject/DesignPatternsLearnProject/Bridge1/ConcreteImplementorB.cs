using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLearnProject.Bridge1
{
    class ConcreteImplementorB : IImplementor
    {
        public void Method() => Console.WriteLine("Method called from the concrete implementor B");
    }
}
