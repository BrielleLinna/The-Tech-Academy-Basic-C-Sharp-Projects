using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            var employee = new Employee("Brielle");
            const string Company = "Dunder Mifflin";
            Console.WriteLine("Welcome to {0}.", Company);
            Console.ReadLine();

            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.EmployeeId);
            Console.ReadLine();
        }
    }
}
