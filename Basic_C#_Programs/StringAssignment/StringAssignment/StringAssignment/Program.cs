using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main()
        {
            string name = "Brielle";
            string input = "I see your destination as airport:";
            string generic = "I hope you are excited for your upcoming travels.";
            Console.WriteLine("Hi" + name + generic + input);
            Console.ReadLine();

            string airportGate = "ogg";
            airportGate = airportGate.ToUpper();
            Console.WriteLine(airportGate);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("You now have two destinations.");
            Console.ReadLine();

            sb.Append("I see you are now stopping in Honolulu on the return.");

            sb.Append("You added two extra nights to your flight.");
         
            sb.Append("I hope you enjoy Hawaii!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
