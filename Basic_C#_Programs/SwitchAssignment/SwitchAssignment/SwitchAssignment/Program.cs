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
            bool codeInput = code == 21;
            bool codeNew = code == 22 || code == 23;

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
                        break;
                    default:
                        Console.WriteLine("No such promo code.");
                        Console.WriteLine("Please enter the promo code:");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                         Console.ReadLine();
                         while (codeNew);
            {
                case 22:
                Console.WriteLine("This promo code is not yet valid. Please try again after November 5th to redeem.");
                break;

                case 23:
                Console.WriteLine("This promo code is not yet valid. Please try again on black friday.");
                break;
            }
            Console.ReadLine();
        }
    }
}
