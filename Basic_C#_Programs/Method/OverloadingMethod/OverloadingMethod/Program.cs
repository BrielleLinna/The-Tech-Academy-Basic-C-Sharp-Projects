using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            
                Numbers newNumbers = new Numbers();

                //One option to call method and put in parameters
                int f = 1;
                double s = 2.2;
                Console.WriteLine(newNumbers.myMethod1(f));
                Console.WriteLine(newNumbers.myMethod1(s));
                Console.WriteLine(newNumbers.myMethod1("3"));
                Console.ReadLine();

            }
        }
    }
}
