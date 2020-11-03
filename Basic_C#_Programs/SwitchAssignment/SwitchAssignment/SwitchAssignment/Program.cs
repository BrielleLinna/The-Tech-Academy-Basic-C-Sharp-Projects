using System;

namespace SwitchAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the promo code:");
            int code = Convert.ToInt32(Console.ReadLine());
            bool codeInput = false;

            do
            {
                switch (code)
                {
                    case 21:
                        Console.WriteLine("21% applied!");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 24:
                        Console.WriteLine("24% applied!");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 27:
                        Console.WriteLine("27% applied!");
                        code = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That promo code is expired or invalid.");
                        Console.WriteLine("Please try again.");
                        code = Convert.ToInt32(Console.ReadLine());
                        Console.ReadLine();
                        break;
                }
            }
                while (!codeInput);
                Console.ReadLine();
        }
    }
}
