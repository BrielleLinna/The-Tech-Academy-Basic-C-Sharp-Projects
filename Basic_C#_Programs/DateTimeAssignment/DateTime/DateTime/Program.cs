using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime
{
    class Program
    {
        private static object file;

        public static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            (StreamWriter file = new (StreamWriter(@"C:\Users\Brielle\Desktop\Basic_C#_Programs", true));
            {
                file.WriteLine(input);
            }

        }
    }
}
