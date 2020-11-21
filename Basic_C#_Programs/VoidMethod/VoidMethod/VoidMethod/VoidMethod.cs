using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class VoidMethod
    {
        public int myMethod (int x, int y)
        {
            return x * y+ 2;
        }

        public int myMethod (int g=2)
        {
            return g;
        }
    }
}
