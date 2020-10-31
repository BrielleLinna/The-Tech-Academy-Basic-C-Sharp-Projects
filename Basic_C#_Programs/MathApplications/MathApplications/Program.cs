using System;

namespace OperationAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            string chosenNumber = Console.ReadLine();
            int newNumber = Convert.ToInt32(chosenNumber);
            int total = newNumber * 50;
            Console.WriteLine("Your number multiplied by 50 =" + total);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string enteredNumber = Console.ReadLine();
            int xNumber = Convert.ToInt32(enteredNumber);
            int combine = xNumber + 25;
            Console.WriteLine("Your number plus 25 =" + combine);
            Console.ReadLine();

            Console.WriteLine("Enter a new number:");
            string newValue = Console.ReadLine();
            float yNumber = Convert.ToInt64(newValue);
            float newCombine = yNumber / 12.5f;
            Console.WriteLine("Your number divided by 12.5 = " + newCombine);
            Console.ReadLine();

            Console.WriteLine("Enter a number you haven't entered yet:");
            string brandNew = Console.ReadLine();
            int update = Convert.ToInt32(brandNew);
            bool trueOrFalse = update > 50;
            Console.WriteLine("Is your number number greater than 50:" + trueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Enter one last number:");
            string lastNumber = Console.ReadLine();
            int remainder = Convert.ToInt32(lastNumber);
            int result = remainder % 7;
            Console.WriteLine("The remainder of your number after being divided by 7 =" + result);
            Console.ReadLine();

        }
    }
}
