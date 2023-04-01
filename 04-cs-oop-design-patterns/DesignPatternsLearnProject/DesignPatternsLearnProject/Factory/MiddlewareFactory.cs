using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLearnProject.Factory
{
    class MiddlewareFactory
    {
        public IMiddleware GetMiddleware(int witch)
        {
            switch (witch)
            {
                case 1: return new MiddlewareOne();
                case 2: return new MiddlewareTwo();
                default: return new MiddlewareOne();
            }
        }

    }
}
