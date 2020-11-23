using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class Division
    {
        public int myMethod(int x)
        {
            return x / 2;
        }

        public double myMethod(double x)
        {
            return x / 2;
        }

        public static int myMethod2(int g, int h)
        {
            return g + h;
        }

        public static int outParameter(out int j)
        {
            return j = 46;
        }
    }
}
