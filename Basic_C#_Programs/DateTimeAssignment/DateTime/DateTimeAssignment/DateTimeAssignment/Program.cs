using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {

        public static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
            Console.WriteLine("Please pick a number.");
            int answer = Convert.ToInt32(Console.ReadLine());

            DateTime XhoursLater = now.AddHours(answer);
       
                Console.WriteLine("It will be:", XhoursLater);
                Console.ReadLine();

            }
        }
}

    
