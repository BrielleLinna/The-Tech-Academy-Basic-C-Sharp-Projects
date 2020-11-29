using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek currentDay;
            Console.WriteLine("Please enter the current day of the week:");
            string input = Console.ReadLine();
         

            try
            {
                currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("Today is" + currentDay);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please write an actual day of the week",e);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            Console.ReadLine();
        }
    }
}
