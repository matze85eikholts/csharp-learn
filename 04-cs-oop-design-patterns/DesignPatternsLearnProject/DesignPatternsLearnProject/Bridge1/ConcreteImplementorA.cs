using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLearnProject.Bridge1
{
    class ConcreteImplementorA : IImplementor
    {
        public void Method() => Console.WriteLine("Method created from the concrete implementor A");
    }
}
