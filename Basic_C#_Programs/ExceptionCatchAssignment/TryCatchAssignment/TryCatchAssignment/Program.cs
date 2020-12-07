using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class Program
    {
        public static string ArugmentException { get; private set; }

        static void Main(string[] args)
        {
          
            DateTime now = DateTime.Now;
            Console.WriteLine("Enter your age:");

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                int dateOfYear = now.Year - age;
                Console.WriteLine("Date of year:" + dateOfYear);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your age can't be zero or negative numbers.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong please try again.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
