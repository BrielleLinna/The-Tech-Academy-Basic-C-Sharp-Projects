using System;

namespace QuoteAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("What is the weight of the package?");
            int weightPackage = Convert.ToInt32(Console.ReadLine());
            if (weightPackage > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of the package?");
                int widthPackage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of the package?");
                int heightPackage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of the package?");
                int lengthPackage = Convert.ToInt32(Console.ReadLine());

                if (widthPackage + heightPackage + lengthPackage > 50)
                { 
                    Console.WriteLine("This package too big to be shipped via Package Express.");
                }
                else 
                {
                    double cost = heightPackage * lengthPackage * widthPackage * weightPackage / 100.00;
                    Console.WriteLine("The estimated total for shipping this package=" + "$" + cost);
                    Console.ReadLine();
                }

            }
        }
    }
}
