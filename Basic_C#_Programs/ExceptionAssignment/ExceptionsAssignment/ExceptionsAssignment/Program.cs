using System;
using System.Collections.Generic;

namespace ExceptionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);

            try
            {
                Console.WriteLine("Pick a number:");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number:");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "divided by" + numberTwo + "equals" + numberThree);
                Console.ReadLine();
            }

            catch(exception );


        }
    }
}
