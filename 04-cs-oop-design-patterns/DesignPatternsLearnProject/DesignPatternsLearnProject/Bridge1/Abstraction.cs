using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLearnProject.Bridge1
{
    class Abstraction
    {
        public IImplementor Implementor { get; set; }
        public virtual void DoOperation() => Implementor.Method();
    }
}
