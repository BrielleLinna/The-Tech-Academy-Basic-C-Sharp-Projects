using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Numbers newNumbers = new Numbers();

            Console.WriteLine("Please pick a whole number:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Numbers.myMethod1(input));
            Console.WriteLine(Numbers.myMethod2(input));
            Console.WriteLine(Numbers.myMethod3(input));
            Console.ReadLine();

        }
    }
}
