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
            DayOfWeek currentDay;
            Console.WriteLine("Please enter the current day of the week:");
            string input = Console.ReadLine();
         

            try
            {
                currentDay = (DayOfWeek)(DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
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
