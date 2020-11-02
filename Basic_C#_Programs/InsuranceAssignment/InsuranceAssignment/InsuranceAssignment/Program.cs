using System;

namespace InsuranceAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int ageInput = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Have you ever had a DUI? True or False:");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            bool trueOrFalse = dui != true;

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualifed?");
            bool qualified = (ageInput >=15 && trueOrFalse && speedingTicket <=3);
            Console.WriteLine(qualified);
            Console.ReadLine();           

        }
    }
}
