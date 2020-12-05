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
        private const string V = @"C:\Users\Brielle\Desktop\Basic_C#_Programs";

        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number.");
            string answer = Console.ReadLine();
            using (StreamWriter file = new StringWriter(V, true))
            {
                file.WriteLine(answer);
            }
        }
    }
}
