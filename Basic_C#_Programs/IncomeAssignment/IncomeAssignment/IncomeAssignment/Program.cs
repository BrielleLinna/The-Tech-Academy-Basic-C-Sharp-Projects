using System;

namespace IncomeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            int personOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWeek = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            int personTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWeekly = Convert.ToInt32(Console.ReadLine());


            float salaryOne = personOne * hoursWeek * 52;
            Console.WriteLine("Annual salary of Person 1:" + "$" + salaryOne);
            Console.ReadLine();

            float salaryTwo = personTwo * hoursWeekly * 52;
            Console.WriteLine("Annual salary of Person 2:" + "$" + salaryTwo);
            Console.ReadLine();

            bool trueOrFalse = salaryOne > salaryTwo;
            Console.WriteLine("Does Person 1 make more money than Person 2?" + trueOrFalse);
            Console.ReadLine();









        }
    }
}
