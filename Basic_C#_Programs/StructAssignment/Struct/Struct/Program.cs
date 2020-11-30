using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StructNumber newNumber = new StructNumber();
            newNumber.Amount = 2.1m;

            Console.WriteLine(newNumber.Amount);
            Console.ReadLine();

        }
    }
}
