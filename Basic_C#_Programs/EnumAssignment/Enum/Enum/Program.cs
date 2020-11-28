using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Days DaysOfTheWeek = new Days();
            Console.WriteLine("Please enter the current day of the week:");
            string dayInput = Console.ReadLine();
            int underlyingValue = Convert.ToInt32(dayInput[7]);

            try
            {
                int[] Days = { 1, 2, 3, 4, 5, 6, 7 };
                Console.WriteLine(dayInput);
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
