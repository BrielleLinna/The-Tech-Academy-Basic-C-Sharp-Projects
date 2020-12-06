using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    public class Program
    {

        static void Main(string[] args)
        {
            string v = @"C:\Users\Brielle\Documents\Logs\log.txt";
            Console.WriteLine("Please pick a number.");
            string answer = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(v, true))
            {
                file.WriteLine(answer);
                Console.ReadLine();
            }

        }
    }
}
