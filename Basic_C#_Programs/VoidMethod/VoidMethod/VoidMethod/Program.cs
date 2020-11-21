using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //instanciating the class
            VoidMethod newVoidMethod = new VoidMethod();


            //Calling method 1 with 2 parameters in operation
            Console.WriteLine(newVoidMethod.myMethod(2, 0));
            Console.ReadLine();
            //Calling function to display default value in method
            Console.WriteLine(newVoidMethod.myMethod());

            //trying to call method using parameter names

            Console.WriteLine(newVoidMethod.myMethod(x:10, y:9));
            Console.ReadLine();
        }
    }
}
