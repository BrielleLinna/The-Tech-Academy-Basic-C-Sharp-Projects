using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Program
    {
        private int x;

        public void Main(string[] args)
        {
            //instanciating the class
            VoidMethod newVoidMethod = new VoidMethod();

            //Calling method 1 with 2 parameters in operation
            Console.WriteLine(newVoidMethod.myMethod(2, 0));
            Console.ReadLine();
            //Calling function to display default value in method
            Console.WriteLine(newVoidMethod.myMethod());

            //trying to call method using parameter names

            //Console.WriteLine(newVoidMethod.myMethod(x = 8, y = 10));
            int number = newVoidMethod.myMethod(1, 2);
           
            int numberOne = newVoidMethod.myMethod(5, 7);

            if (numberOne == 5)
            {
                Console.WriteLine(newVoidMethod.myMethod(numberOne));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(newVoidMethod.myMethod(number, numberOne));
                Console.ReadLine();
            }
        
        }
    }
}
