using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("\n Student Daily Report");
            Console.WriteLine("\n What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine(yourName);
            Console.WriteLine("\n What course are you on?");
            string courseNumber = Console.ReadLine();
            Console.WriteLine(courseNumber);
            Console.WriteLine("\n What page are you on?");
            string pageNumber = Console.ReadLine();
            int pNumber = Convert.ToInt32(pageNumber);
            Console.WriteLine(pNumber);
            Console.WriteLine("\n Do you need help with anything? Please answer \"true or false\"");
            bool help= Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(help);
            Console.WriteLine("\n Were there any positive experiences you'd like to share? Please give specifics");
            string experience = Console.ReadLine();
            Console.WriteLine(experience);
            Console.WriteLine("\n Is there any other feedback you would like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);
            Console.WriteLine("How many hours did you study today?");
            string hoursStudyed = Console.ReadLine();
            int hours = Convert.ToInt32(hoursStudyed);
            Console.ReadLine();
            Console.WriteLine(hours);
            Console.WriteLine("\n Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}