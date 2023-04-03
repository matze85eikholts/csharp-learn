using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLearnProject.Bridge1
{
    class DerivedAbstraction : Abstraction
    {
        public override void DoOperation() => Implementor.Method();
    }
}
