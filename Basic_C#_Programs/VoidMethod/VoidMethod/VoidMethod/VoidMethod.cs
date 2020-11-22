using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class VoidMethod
    {
        public void myMethod (int x, int y)
        {
            Console.WriteLine( x *  y);
        }

        public int myMethod (int g=2)
        {
            return g;
        }
    }
}
