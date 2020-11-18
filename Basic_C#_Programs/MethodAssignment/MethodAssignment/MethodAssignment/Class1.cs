using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    public class Numbers
    {
        static int myMethod1(int x)
        {
            return 10 + x;
        }

        static int myMethod2(int y)
        {
            return 100 / y;
        }

        static int myMethod3(int z)
        {
            return 15 * z;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(myMethod1(3));
            Console.WriteLine(myMethod2(78));
            Console.WriteLine(myMethod3(90));
        }
    }
}
   
