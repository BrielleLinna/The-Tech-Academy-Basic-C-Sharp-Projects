using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignment
{
    public class Program
    {

        static void Main(string[] args)
        {
          
            Console.WriteLine("Please pick a number.");
            string answer = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Brielle\Documents\Logs\log.txt", answer);

            Console.WriteLine(answer);
            File.ReadAllText(@"C:\Users\Brielle\Documents\Logs\log.txt");
            Console.ReadLine();

        }
    }
}
