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

            Console.WriteLine("Please enter a whole number:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(newDivision.myMethod(input));
            Console.ReadLine();
        }
    }
}
