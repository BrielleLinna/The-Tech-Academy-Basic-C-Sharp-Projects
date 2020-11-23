using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instantiating the class
            Division newDivision = new Division();

            //Calling user input and assigning it a variable
            Console.WriteLine("Please enter a whole number:");
            int input = Convert.ToInt32(Console.ReadLine());

            //Calling myMethod with user input as value to undergo division and display as integer
            Console.WriteLine(newDivision.myMethod(input));
            Console.ReadLine();

            //Overloading method with new type in this case double
            Console.WriteLine(newDivision.myMethod(2.2));
            Console.ReadLine();

            //creating static myMethod2 by not instanciating it and making it static inside class
            Console.WriteLine(Division.myMethod2(4, 5));
            Console.ReadLine();

            //out parameters
            int j;
            Console.WriteLine(Division.outParameter(out j));
            Console.ReadLine();
        }
    }
}
