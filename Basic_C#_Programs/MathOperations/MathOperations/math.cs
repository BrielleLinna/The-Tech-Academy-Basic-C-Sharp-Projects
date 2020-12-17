using System;

namespace OperationAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32 (Console.ReadLine() * 50);
            Console.WriteLine("The value is:" + x);
        }
    }
}