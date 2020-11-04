using System;
using System.Collections;

namespace SwitchAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the promo code:");
            int code = Convert.ToInt32(Console.ReadLine());
            bool codeInput = true;

            do
            {
                switch (code)
                {
                    case 20:
                        Console.WriteLine("You entered 20, that is not a valid code.");
                        Console.WriteLine("Please enter the promo code:");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 24:
                        Console.WriteLine("You entered 24, that is not a valid code.");
                        Console.WriteLine("Please enter the promo code:");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("Your promo code 21 was accepted, receive 21% off!");
                        codeInput = false;
                        break;
                    default:
                        Console.WriteLine("No such promo code.");
                        Console.WriteLine("Please enter the promo code:");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }
            while (codeInput == true);

            Console.WriteLine("Guess what year I was born?");
            int year = Convert.ToInt32(Console.ReadLine());
            bool yearTrue = true;

            switch (year)
            {
                case 1994:
                    Console.WriteLine("I was not born in 1994.");
                    Console.WriteLine("Guess what year I was born?");
                    year = Convert.ToInt32(Console.ReadLine());
                    break;

                case 1992:
                    Console.WriteLine("I was not born in 1992.");
                    Console.WriteLine("Guess what year I was born?");
                    year = Convert.ToInt32(Console.ReadLine());
                    break;

                case 1993:
                    Console.WriteLine("I was born in 1993, good job!");
                    yearTrue = false;
                    break;

            }
            Console.ReadLine();
            while (yearTrue == true);
        }   
    }
}