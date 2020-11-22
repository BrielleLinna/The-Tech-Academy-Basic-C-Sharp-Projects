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


            newVoidMethod.myMethod(Console.WriteLine(y));
          

            //trying to call method using parameter names

            Console.WriteLine(newVoidMethod.myMethod(x:10, y:9));
            Console.ReadLine();
        }
    }
}
