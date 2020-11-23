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

            //calling default values with the method
            Console.WriteLine(newVoidMethod.myMethod());
          

            //calling in the void method passing in parameters

            newVoidMethod.myMethod(x:10, y:9);
            Console.ReadLine();

            //calling in a method using parameter names 
            Console.WriteLine(newVoidMethod.myMethod1(firstNumber: 43, secondNumber: 56));
            Console.ReadLine();
        }
    }
}
