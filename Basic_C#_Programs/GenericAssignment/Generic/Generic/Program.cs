using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            
            employee.Things.Add ( "Active");
            employee.Things.Add ("Furloughed");
            employee.Things.Add("Terminated");

            Console.WriteLine(employee);
            Console.ReadLine();

            Employee<int> employeeId = new Employee<int>();
            employeeId.Things = new List<int>();

            employeeId.Things.Add(21);
            employeeId.Things.Add(22);
            employeeId.Things.Add(23);

            //trying to create a loop to print out everything in our employee.Things list
            foreach (var Thing in employee.Things)
            {
                Console.WriteLine(Thing);
                Console.ReadLine();
            }
            foreach (var Thing2 in employeeId.Things)
            {
                Console.WriteLine(Thing2);
                Console.ReadLine();
            }
        }
    }
}
